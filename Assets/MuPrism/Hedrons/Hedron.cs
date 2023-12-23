using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;

public class HedronView: ViewModel
{
    public HedronView(Hedron hedron): base(hedron)
    {

    }
}

public class HedronController: ModelController
{
    public HedronController(Hedron hedron) : base(hedron) 
    { 
    
    }
}

public class Hedron : IModel, IHedron
{
    public Dictionary<Particle, IPrism> Registry { get; set; } = new();
    public Particle LeadParticle { get; set; }

    public ViewModel ModelView => null;

    public ModelController ModelController => null;

    public List<IPrism> Prisms => Registry.Values.ToList();

    public Hedron(IHedron hedron)
    {
        this.LeadParticle = hedron.LeadParticle;
        this.Registry = hedron.Registry;
    }

    public Hedron()
    {
        this.LeadParticle = Particle.Delta;
        foreach (Particle particle in Enum.GetValues(typeof(Particle)))
        {
            Registry.Add(particle, new ParticlePrism(particle, this.LeadParticle));
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

    public IPrism GetPrism(Particle pid)
    {
        if (this.Registry.ContainsKey(pid)) return this.Registry[pid];
        return null;
    }

    public IPrism GetLeadPrism()
    {
        return this.GetPrism(this.LeadParticle);
    }

    public IPrism AddPrism(ParticlePrism prism)
    {
        return this.AddPrism(prism, prism.Pid);
    }

    public void Update()
    {
        throw new NotImplementedException();
    }
}

public class SinglePrismHedron : Hedron
{
    public SinglePrismHedron(IPrism prism) : base()
    {
        this.LeadParticle = prism.Pid;
        prism.Hid = this.LeadParticle;
        this.AddPrism(prism, prism.Pid);
    }
}

public class LeaderPrismHedron : Hedron
{
    public LeaderPrismHedron(Particle lead, List<Prism> prisms) : base()
    {
        this.LeadParticle = lead;
        var particles = Enum.GetValues(typeof(Particle));

        var avaliablePrisms = new Stack<Prism>();
        foreach (var prism in prisms)
        {
            avaliablePrisms.Push(prism);
        }

        var index = 0;
        var particlesVisted = new List<Particle>();
        while (avaliablePrisms.Count > 0)
        {
            Prism prism = avaliablePrisms.Pop();
            Particle pid = (Particle)particles.GetValue(index);

            AddPrism(prism, pid);

            particlesVisted.Add(pid);

            index++;
        }
    }

    public LeaderPrismHedron(Particle lead, Dictionary<Particle, IPrism> prisms) : base()
    {
        this.LeadParticle = lead;
        this.Registry = prisms;
    }
}
