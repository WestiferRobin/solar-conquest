using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class SolarSystem: GameBoardItem<SolarSystem>, IModel, IParticle
    {
        public Particle ParticleID { get; private set; }
        public List<LifePlanet> InnerPlanets { get; set; }
        public List<GasPlanet> OuterPlanets { get; set; }

        public SolarSystem()
        {
            this.ParticleID = IParticle.GetRandom();
            this.InnerPlanets = RandomSolarSystem.CreateRandomInnerPlanets();
            this.OuterPlanets = RandomSolarSystem.CreateRandomOuterPlanets();
        }

        public SolarSystem(Particle particle)
        {
            this.ParticleID = particle;
            this.InnerPlanets = RandomSolarSystem.CreateRandomInnerPlanets();
            this.OuterPlanets = RandomSolarSystem.CreateRandomOuterPlanets();
        }

        public SolarSystem(List<LifePlanet> innerPlanets, List<GasPlanet> outerPlanets)
        {
            this.ParticleID = IParticle.GetRandom();
            this.InnerPlanets = innerPlanets;
            this.OuterPlanets = outerPlanets;
        }

        public SolarSystem(Particle particle, List<LifePlanet> innerPlanets, List<GasPlanet> outerPlanets)
        {
            this.ParticleID = particle;
            this.InnerPlanets = innerPlanets;
            this.OuterPlanets = outerPlanets;
        }

        public new void Update()
        {
            foreach (var corePlanet in InnerPlanets)
            {
                corePlanet.Update();
            }
            foreach (var gasGiant in OuterPlanets)
            {
                gasGiant.Update();
            }
        }

        public virtual void Build()
        {
            foreach (var planet in this.InnerPlanets)
            {
                planet.Build();
            }

            foreach (var planet in this.OuterPlanets)
            {
                planet.Build();
            }
        }
    }
}
