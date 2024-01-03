using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoverignParticles;

namespace SolarConquestGameModels
{
    public class RandomSolarSystem
    {
        public static List<LifePlanet> CreateRandomInnerPlanets()
        {
            return CreateRandomInnerPlanets(IParticle.GetRandom());
        }

        public static List<LifePlanet> CreateRandomInnerPlanets(Particle particle)
        {
            var rand = new Random();

            var innerPlanets = new List<LifePlanet>();
            int innerPlanetSize = rand.Next(4);

            for (int index = 0; index < innerPlanetSize; index++)
            {
                int moonSize = rand.Next(3);
                var planet = new LifePlanet(particle, $"Inner Planet {index}", moonSize);
                innerPlanets.Add(planet);
            }

            return innerPlanets;
        }

        public static List<GasPlanet> CreateRandomOuterPlanets()
        {
            return CreateRandomOuterPlanets(IParticle.GetRandom());
        }

        public static List<GasPlanet> CreateRandomOuterPlanets(Particle particle)
        {
            var rand = new Random();

            var outerPlanets = new List<GasPlanet>();
            int outerPlanetSize = rand.Next(4);

            for (int index = 0; index < outerPlanetSize; index++)
            {
                int deadMoonSize = rand.Next(3);
                int lifeMoonSize = rand.Next(3) + 1;
                var planet = new GasPlanet(particle, $"Outer Planet {index}", lifeMoonSize, deadMoonSize);
                outerPlanets.Add(planet);
            }

            return outerPlanets;
        }
    }
}
