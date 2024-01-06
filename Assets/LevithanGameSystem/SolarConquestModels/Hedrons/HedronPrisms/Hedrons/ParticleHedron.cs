using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;

public class ParticleHedron : IModel, IHedron
{
    public Dictionary<Particle, IPrism> Registry { get; set; } = new();

    public List<IPrism> Prisms => Registry.Values.ToList();

    public Particle ParticleID { get; set; }

    public ParticleHedron(IHedron hedron)
    {
        this.ParticleID = hedron.ParticleID;
        this.Registry = hedron.Registry;
    }

    public ParticleHedron(IHedron hedron, Particle hid)
    {
        this.ParticleID = hid;
        this.Registry = hedron.Registry;
    }

    public ParticleHedron(Particle pid, Dictionary<Particle, IPrism> registry)
    {
        this.ParticleID = pid;
        registry ??= new Dictionary<Particle, IPrism>();
        this.Registry = registry;
    }


    public ParticleHedron(Particle hid = Particle.Delta, bool isFull = false)
    {
        this.ParticleID = hid;
        this.Registry = new()
        {
            { hid, new ParticlePrism(hid) }
        };
        if (isFull)
        {
            foreach (Particle pid in Enum.GetValues(typeof(Particle)))
            {
                if (pid == hid) continue;
                this.Registry.Add(pid, new ParticlePrism(pid, hid));
            }
        }
    }

    public ParticleHedron(ParticlePrism leader, bool isFull = false)
    {
        this.ParticleID = leader.Hid;
        this.Registry = new()
        {
            { leader.Hid, leader }
        };
        if (isFull)
        {
            foreach (Particle pid in Enum.GetValues(typeof(Particle)))
            {
                if (pid == leader.Hid) continue;
                this.Registry.Add(pid, new ParticlePrism(pid, leader.Hid));
            }
        }
    }

    public ParticleHedron(ParticlePrism leader, List<ParticlePrism> prisms)
    {
        this.ParticleID = leader.Hid;
        this.Registry = new();
        ConfigureHedron(leader, prisms);
    }

    private void ConfigureHedron(IPrism leader, List<IPrism> prisms)
    {
        var particleLeader = new ParticlePrism(leader, leader.Hid);
        var particlePrisms = new List<ParticlePrism>();
        var rawRegistry = IParticle.GetDictionary(prisms);
        foreach (var pid in rawRegistry.Keys)
        {
            var prism = rawRegistry[pid];
            var particlePrism = new ParticlePrism(prism, pid);
            particlePrisms.Add(particlePrism);
        }
        ConfigureHedron(particleLeader, particlePrisms);
    }

    private void ConfigureHedron(ParticlePrism leader, List<ParticlePrism> prisms)
    {
        this.Registry.Add(leader.Hid, leader);

        var stack = new Stack<IPrism>();
        foreach (var prism in prisms) stack.Push(prism);
        stack.Push(leader);

        while (stack.Count > 0)
        {
            var prism = stack.Pop();

            Particle pid = prism.Pid;
            if (this.Registry.Keys.Contains(prism.Pid))
            {
                pid = IParticle.GetRandom();
                var size = IParticle.GetList().Count;
                var visitedParticles = new List<Particle>();
                while (
                    this.Registry.Keys.Contains(pid) &&
                    visitedParticles.Count < size
                )
                {
                    pid = IParticle.GetRandom();
                    if (!visitedParticles.Contains(pid))
                        visitedParticles.Add(pid);
                }
                if (this.Registry.Keys.Contains(pid)) continue;
            }

            this.Registry.Add(pid, prism);
        }
    }

    public IPrism AddPrism(IPrism prism, Particle pid)
    {
        if (Registry.ContainsKey(pid))
        {
            if (prism.IsAlive()) return prism;
            else Registry[pid] = prism;
        }
        else
        {
            Registry.Add(pid, prism);
        }
        return prism;
    }

    public IPrism RemovePrism(Particle pid)
    {
        if (Registry.ContainsKey(pid))
        {
            var oldPrism = Registry[pid];
            if (Registry.Remove(pid)) return oldPrism;
        }
        return null;
    }

    public bool IsAlive()
    {
        bool isAlive = false;
        foreach (var pid in Registry.Keys)
        {
            var prism = Registry[pid];
            isAlive |= prism.IsAlive();
        }
        return isAlive;
    }

    public IPrism GetPrism()
    {
        var pid = IParticle.GetRandom();
        while (!this.Registry.ContainsKey(pid))
        {
            pid = IParticle.GetRandom();
        }
        return this.Registry[pid];
    }

    public IPrism GetPrism(Particle pid)
    {
        if (this.Registry.ContainsKey(pid)) return this.Registry[pid];
        return null;
    }

    public void SetLeadPrism(IPrism newLead)
    {
        var lead = this.GetLeadPrism();
        var members = this.Prisms.Where(
            member => lead.Pid != member.Pid
        ).ToList();
        this.Registry.Clear();

        ConfigureHedron(newLead, members);
    }

    public IPrism GetLeadPrism()
    {
        return this.GetPrism(this.ParticleID);
    }

    public IPrism AddPrism(ParticlePrism prism)
    {
        return this.AddPrism(prism, prism.Pid);
    }

    public void Update()
    {
        foreach (IPrism prism in this.Prisms)
        {
            prism.Update();
        }
    }
}

public class SinglePrismHedron : ParticleHedron
{
    public SinglePrismHedron(ParticlePrism prism) : base(prism.Pid)
    {
        prism.Hid = this.ParticleID;
        this.AddPrism(prism, prism.Pid);
    }

    public SinglePrismHedron(IPrism prism, Particle pid) : base(pid)
    {
        prism.Hid = this.ParticleID;
        this.AddPrism(prism, prism.Pid);
    }
}

public class LeaderPrismHedron : ParticleHedron
{
    public LeaderPrismHedron(Particle hid, List<IPrism> prisms) : base(hid)
    {
        var particles = Enum.GetValues(typeof(Particle));

        var avaliablePrisms = new Stack<IPrism>();
        foreach (var prism in prisms)
        {
            avaliablePrisms.Push(prism);
        }

        var index = 0;
        var particlesVisted = new List<Particle>();
        while (avaliablePrisms.Count > 0)
        {
            IPrism prism = avaliablePrisms.Pop();
            Particle pid = (Particle)particles.GetValue(index);

            AddPrism(prism, pid);

            particlesVisted.Add(pid);

            index++;
        }
    }

    public LeaderPrismHedron(Particle hid, Dictionary<Particle, IPrism> prisms) : base()
    {
        this.ParticleID = hid;
        this.Registry = prisms;
    }
}
