using Assets.SolarConquestModel.Grid;
using SolarConquest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.VisualScripting;

namespace SolarConquest
{
    public class SolarGrid: IGridUpdater
    {
        public List<Planet> InnerPlanets { get; private set; }
        public List<Planet> OuterPlanets { get; private set; }

        public SolarGrid(List<Planet> innerPlanets, List<Planet> outerPlanets)
        {
            this.InnerPlanets = innerPlanets;
            this.OuterPlanets = outerPlanets;
        }

        public void Update()
        {
            foreach (var innerPlanet in this.InnerPlanets)
            {
                innerPlanet.Update();
            }
            foreach (var outerPlanet in this.OuterPlanets)
            {
                outerPlanet.Update();
            }
        }

        public SolarGrid() {
            var rand = new Random();

            this.InnerPlanets = new();
            int innerPlanetSize = rand.Next(0, 3) + 1;
            for (int index =  0; index < innerPlanetSize; index++)
            {
                int moonSize = rand.Next(3);
                var planet = new LifePlanet($"Inner Planet {index}", moonSize);
                this.InnerPlanets.Add(planet);
            }

            this.OuterPlanets = new();
            int outerPlanetSize = rand.Next(3) + 1;
            for (int index = 0; index < outerPlanetSize; index++)
            {
                int deadMoonSize = rand.Next(3);
                int lifeMoonSize = rand.Next(3) + 1;
                var planet = new GasPlanet($"Outer Planet {index}", lifeMoonSize, deadMoonSize);
                this.OuterPlanets.Add(planet);
            }
        }
    }

    public class FactionSolarGrid: SolarGrid
    {
        public FactionSolarGrid(): base(
            new List<Planet>() {
                new LifePlanet("Venus", moonSize: 0),
                new LifePlanet("Earth", moonSize: 1),
                new LifePlanet("Mars", moonSize: 2),
            },
            new List<Planet>() {
                new GasPlanet("Jupiter", lifeMoonSize: 3, deadMoonSize: 2),
                new GasPlanet("Saturn", lifeMoonSize: 2, deadMoonSize: 1),
                new GasPlanet("Neptune", lifeMoonSize: 1, deadMoonSize: 0)
            }
        )
        {

        }
    }
}
