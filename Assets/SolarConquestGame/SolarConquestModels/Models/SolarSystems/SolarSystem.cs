using SolarConquestGameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class SolarSystem
    {
        public List<LifePlanet> InnerPlanets { get; set; }
        public List<GasPlanet> OuterPlanets { get; set; }

        public SolarSystem()
        {
            this.InnerPlanets = new List<LifePlanet>();
            this.OuterPlanets = new List<GasPlanet>();
        }

        public SolarSystem(List<LifePlanet> innerPlanets, List<GasPlanet> outerPlanets)
        {
            this.InnerPlanets = innerPlanets;
            this.OuterPlanets = outerPlanets;
        }

        public void Update()
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
    }
}
