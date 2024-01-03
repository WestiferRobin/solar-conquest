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

        public IPrism Admin { get; }

        public IPrism AdminGuardian => Avatar;

        public IArchFaction AdminFaction { get; }

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

        public IPrism GetArchLeader(Particle particle)
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

        public IPrism GetArchGuardian(Particle particle)
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

        public void ApplyToBoard(GalaxyBoard galaxy, int index)
        {
            int boardLength = galaxy.Board.Count;
            var factionLine = new GameBoardLine<SolarSystem>();
            var adminSystem = new AdminSolarSystem(this.AdminFlag, this.ArchFlags);

            factionLine.AddItem(adminSystem);

            foreach (var archLeaderflag in this.GetFlags())
            {
                var factionFlags = this.GetFlags();
                var archFlags = IParticle.GetRandomList(factionFlags);

                var archSystem = new ArchSolarSystem(archLeaderflag, archFlags);

                factionLine.AddItem(archSystem);
            }

            var factionSystems = new List<SolarSystem>();
            var list = IParticle.GetRandomList();
            foreach (var particle in list)
            {
                if (factionLine.BoardItems.Where(t => t.Model.ParticleID == particle).Any())
                {
                    SolarSystem system = factionLine.BoardItems
                        .Where(t => t.Model.ParticleID == particle)
                        .First().Model;
                }
            }

            galaxy.Board[index % boardLength] = factionLine;
        }
    }
}
