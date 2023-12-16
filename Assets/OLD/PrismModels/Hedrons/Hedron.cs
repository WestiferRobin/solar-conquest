
using SoverignParticles;
using System;
using System.Collections.Generic;

namespace SolarConquest
{

    public class SinglePrismHedron: Hedron
    {
        public SinglePrismHedron(Prism prism): base()
        {
            this.LeadParticle = prism.Pid;
            prism.Hid = this.LeadParticle;
            this.AddPrism(prism, prism.Pid);
        }
    }

    public class LeaderPrismHedron: Hedron
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

        public LeaderPrismHedron(Particle lead, Dictionary<Particle, Prism> prisms) : base()
        {
            this.LeadParticle = lead;
            this.Registry = prisms;
        }
    }

    
    public class AntiHedron: Hedron
    {
        public AntiHedron(): base()
        {
            this.LeadParticle = Particle.Mu;
            this.Registry = new() {
                    {this.LeadParticle, new ParticlePrism(this.LeadParticle, this.LeadParticle) }
                };
        }
    }


    public class Hedron: IModel
    {
        public Dictionary<Particle, Prism> Registry = new();
        public Particle LeadParticle { get; set; }

        public ViewModel ModelView => throw new NotImplementedException();

        public ModelController ModelController => throw new NotImplementedException();

        public Hedron(Hedron hedron)
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

        public Prism AddPrism(Prism prism, Particle pid)
        {
            if (Registry.ContainsKey(pid))
            {
                if (prism.IsAlive()) return prism;
                else Registry[pid] = prism;
            } else
            {
                Registry.Add(pid, prism);
            }
            return prism;
        }

        public Prism RemovePrism(Particle pid)
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

        internal Prism GetPrism(Particle delta)
        {
            throw new NotImplementedException();
        }

        public Prism GetLeadPrism()
        {
            return this.GetPrism(this.LeadParticle);
        }
    }
}
