using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class TerraSolarSystem: SolarSystem
    {
        public TerraSolarSystem(): base()
        {
            this.OuterPlanets = new List<GasPlanet>()
            {
                new Jupiter(),
                new Saturn(),
                new Neptune()
            };
            this.InnerPlanets = new List<LifePlanet>()
            {
                new Venus(),
                new Terra(),
                new Mars()
            };
        }
    }
}
