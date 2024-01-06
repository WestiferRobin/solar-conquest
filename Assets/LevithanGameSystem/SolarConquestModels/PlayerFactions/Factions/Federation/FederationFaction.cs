using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class FederationFaction : PlayerFaction
    {
        public static Particle FederationFlag = Particle.Delta;
        public static List<Particle> FederationArchFlags
        {
            get {
                var archFlags = new List<Particle>();
                foreach (var race in FederationRaces)
                {
                    var archFlag = (Particle) race;
                    archFlags.Add(archFlag);
                }
                return archFlags;
            }
        }
        public static List<RaceID> FederationRaces = new()
        {
            RaceID.Atlantian,
            RaceID.Terrian,
            RaceID.Martian,
            RaceID.Venatoan,
            RaceID.Nepatoan
        };

        public static List<Particle> FederationFlags { get {
                var archFlags = new List<Particle>() { FederationFlag };
                foreach (var archFlag in FederationArchFlags)
                {
                    archFlags.Add(archFlag);
                }
                return archFlags;
            }
        }

        public FederationFaction(IHedron hedron) : base(
            new ParticleHedron(hedron, FederationFlag),
            FederationFlag,
            FederationArchFlags
        )
        {
            Init();
        }

        public FederationFaction(ParticleHedron avatarHedron): base(
            avatarHedron,
            FederationFlag,
            FederationArchFlags
        )
        {
            Init();
        }

        private void Init()
        {
            foreach (var federationFlag in this.GetFlags())
            {
                var federationHedron = new FederationHedron();
                var leader = federationHedron.GetPrism(federationFlag);
                var guardian = federationHedron.GetPrism();

                var federationFaction = new FederationArchFaction(
                    new FederationPrism(leader),
                    new FederationPrism(guardian)
                );
                this.Factions[federationFlag] = federationFaction;
            }
        }
    }
}
