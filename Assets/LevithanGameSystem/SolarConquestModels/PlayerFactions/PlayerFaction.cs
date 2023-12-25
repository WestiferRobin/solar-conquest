using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEditor.Search;
using UnityEngine;

namespace SolarConquestGameModels
{

    public abstract class PlayerFaction: IAdminFaction
    {
        public IHedron AvatarHedron { get; }
        public IPrism Avatar { get => AvatarHedron.GetLeadPrism(); }

        public IPrism Admin => throw new NotImplementedException();

        public IPrism AdminGuardian => Avatar;

        public IArchFaction AdminFaction => throw new NotImplementedException();

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

        protected readonly Dictionary<Particle, IArchFaction> Factions;

        public PlayerFaction(ParticleHedron avatarHedron, Particle adminFlag, List<Particle> archFlags) {
            this.AvatarHedron = avatarHedron;
            
            this.AdminFlag = adminFlag;
            this.ArchFlags = archFlags;
            this.Factions = new Dictionary<Particle, IArchFaction>();
        }

        public bool IsOperational()
        {
            return GetAdmin().IsAlive() && GetAdminGuardian().IsAlive();
        }

        public IPrism GetAdmin()
        {
            return Factions[AdminFlag].Leader;
        }

        public IPrism GetAdminGuardian()
        {
            return Factions[AdminFlag].Guardian;
        }

        public IArchFaction GetAdminFaction()
        {
            return Factions[AdminFlag];
        }

        public IArchFaction GetArchFaction(Particle pid)
        {
            if (Factions.ContainsKey(pid))
            {
                return Factions[pid];
            }
            else
            {
                return null;
            }
        }

        public IPrism GetLeader(Particle particle)
        {
            if (Factions.ContainsKey(particle))
            {
                return GetArchFaction(particle).Leader;
            }
            else
            {
                return null;
            }
        }

        public IPrism GetGuardian(Particle particle)
        {
            if (Factions.ContainsKey(particle))
            {
                return GetArchFaction(particle).Guardian;
            }
            else
            {
                return null;
            }
        }

        public void Update()
        {
            foreach (IArchFaction raceFaction in this.Factions.Values)
            {
                raceFaction.Update();
            }
        }
    }
}
