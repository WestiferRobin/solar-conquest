using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEditor.Search;
using UnityEngine;

namespace SolarConquest
{

    public abstract class PlayerFaction: IFaction
    {
        public Hedron AvatarHedron { get; }
        public Prism Avatar { get => AvatarHedron.GetPrism(AvatarHedron.LeadParticle); }

        public readonly Particle AdminFlag;
        public readonly List<Particle> ArchFlags;
        public List<Particle> GetFlags()
        {
            var flags = new List<Particle>() { AdminFlag };
            foreach (var flag in ArchFlags)
            {
                flags.Add(flag);
            }
            return flags;
        }

        protected readonly Dictionary<Particle, IFaction> Factions;

        public PlayerFaction(Hedron avatarHedron, Particle adminFlag, Particle archFlag1, Particle archFlag2, Particle archFlag3, Particle archFlag4) {
            this.AvatarHedron = avatarHedron;
            
            this.AdminFlag = adminFlag;
            this.ArchFlags = new List<Particle>()
            {
                archFlag1,
                archFlag2,
                archFlag3,
                archFlag4
            };
            this.Factions = new Dictionary<Particle, IFaction>();
        }

        public bool IsOperational()
        {
            return GetAdmin().IsAlive() && GetAdminGuardian().IsAlive();
        }

        public Prism GetAdmin()
        {
            return Factions[AdminFlag].GetLeader();
        }

        public Prism GetAdminGuardian()
        {
            return Factions[AdminFlag].GetGuardian();
        }

        public IFaction GetAdminFaction()
        {
            return Factions[AdminFlag];
        }

        public IFaction GetArchFaction(Particle particle)
        {
            if (Factions.ContainsKey(particle))
            {
                return Factions[particle];
            }
            else
            {
                return null;
            }
        }

        public Prism GetArch(Particle particle)
        {
            if (Factions.ContainsKey(particle))
            {
                return GetArchFaction(particle).GetLeader();
            }
            else
            {
                return null;
            }
        }

        public Prism GetArchGuardian(Particle particle)
        {
            if (Factions.ContainsKey(particle))
            {
                return GetArchFaction(particle).GetGuardian();
            }
            else
            {
                return null;
            }
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public Prism GetGuardian()
        {
            throw new NotImplementedException();
        }

        public Prism GetLeader()
        {
            throw new NotImplementedException();
        }
    }
}
