using SolarConquest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor.Search;

namespace SolarConquest
{
    public class EmpirePrism : Prism
    {
        public EmpirePrism(Prism prism) : base(prism) { }
    }

    public class EmpireHedron : Hedron
    {
        public EmpireHedron(Hedron hedron) : base(hedron) { }
    }

    public class EmpireSquadron : EmpireHedron
    {
        public EmpireSquadron(Hedron hedron) : base(hedron) { }
    }

    public class EmpireFaction : IFaction
    {
        private EmpirePrism avatar;
        private EmpireHedron avatarHedron;

        private readonly Particle adminFlag = Particle.Omega;
        private readonly List<Particle> archFlags = new() {
            Particle.Psi,
            Particle.Theta,
            Particle.Phi,
            Particle.Sigma
        };
        public EmpireFaction(Prism avatar, Hedron avatarHedron)
        {
            this.avatar = new EmpirePrism(avatar);
            this.avatarHedron = new EmpireHedron(avatarHedron);
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
