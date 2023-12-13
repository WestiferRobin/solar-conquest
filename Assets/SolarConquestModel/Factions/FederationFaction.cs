using SolarConquest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class FederationPrism: Prism {
        public FederationPrism(Prism prism): base(prism) { }
    }

    public class FederationHedron: Hedron
    {
        public FederationHedron(Hedron hedron): base(hedron) { }
    }

    public class FederationSquadron: FederationHedron
    {
        public FederationSquadron(Hedron hedron): base(hedron) { }
    }

    public class FederationFaction : IFaction
    {
        private FederationPrism avatar;
        private FederationHedron avatarHedron;

        private readonly Particle adminFlag = Particle.Delta;
        private readonly List<Particle> archFlags = new() {
            Particle.Lambda,
            Particle.Alpha,
            Particle.Gamma,
            Particle.Beta
        };

        public FederationFaction(Prism avatar, Hedron avatarHedron) { 
            this.avatar = new FederationPrism(avatar);
            this.avatarHedron = new FederationHedron(avatarHedron);
        }

        public Prism GetAvatar()
        {
            return avatar;
        }

        public Hedron GetAvatarHedron()
        {
            return avatarHedron;
        }

        public List<Particle> GetFactionFlags()
        {
            var factionFlags = new List<Particle>
            {
                adminFlag
            };
            foreach (var flag in archFlags)
            {
                factionFlags.Add(flag);
            }
            return factionFlags;
        }

        public bool IsAlive()
        {
            return this.GetAvatarHedron().IsAlive() && this.GetAvatar().IsAlive();
        }

        public Prism GetArch()
        {
            throw new NotImplementedException();
        }

        public Prism GetArchGuardian()
        {
            throw new NotImplementedException();
        }

        public Dictionary<FamilyName, Dictionary<string, List<Family>>> GetArchFamilyRegistry()
        {
            throw new NotImplementedException();
        }

        public Dictionary<FamilyName, Dictionary<string, List<Hedron>>> GetArchArmyRegistry()
        {
            throw new NotImplementedException();
        }

        public void FactionTurn()
        {
            throw new NotImplementedException();
        }
    }
}
