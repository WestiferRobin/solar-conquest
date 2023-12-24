using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class RandomSolarSystem : SolarSystem
    {
        public RandomSolarSystem() : base(
            CreateRandomInnerPlanets(),
            CreateRandomOuterPlanets()
        )
        {

        }

        private static List<LifePlanet> CreateRandomInnerPlanets()
        {
            var rand = new Random();

            var innerPlanets = new List<LifePlanet>();
            int innerPlanetSize = rand.Next(0, 3) + 1;

            for (int index = 0; index < innerPlanetSize; index++)
            {
                int moonSize = rand.Next(3);
                var planet = new LifePlanet($"Inner Planet {index}", moonSize);
                innerPlanets.Add(planet);
            }

            return innerPlanets;
        }

        private static List<GasPlanet> CreateRandomOuterPlanets()
        {
            var rand = new Random();

            var outerPlanets = new List<GasPlanet>();
            int outerPlanetSize = rand.Next(3) + 1;

            for (int index = 0; index < outerPlanetSize; index++)
            {
                int deadMoonSize = rand.Next(3);
                int lifeMoonSize = rand.Next(3) + 1;
                var planet = new GasPlanet($"Outer Planet {index}", lifeMoonSize, deadMoonSize);
                outerPlanets.Add(planet);
            }

            return outerPlanets;
        }
    }
}
