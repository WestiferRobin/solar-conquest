
using System;
using System.Collections.Generic;

namespace SolarConquest
{
    public class Hedron
    {
        public Dictionary<Particle, Prism> Registry = new();
        public Particle LeadParticle { get; set; }

        public Hedron(Hedron hedron)
        {
            this.LeadParticle = hedron.LeadParticle;
            this.Registry = hedron.Registry;
        }

        public Hedron(Prism prism)
        {
            this.LeadParticle = prism.Pid;
            prism.Hid = this.LeadParticle;
            this.AddPrism(prism, prism.Pid);
        }

        public Hedron(Particle lead, Dictionary<Particle, Prism> prisms)
        {
            this.LeadParticle = lead;
            this.Registry = prisms;
        }

        public Hedron(Particle lead, List<Prism> prisms)
        {
            this.LeadParticle=lead;
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
    }
}
