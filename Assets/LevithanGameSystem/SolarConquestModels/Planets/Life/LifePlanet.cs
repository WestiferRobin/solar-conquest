using SolarConquestGameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{

    public class LifePlanet : DeadPlanet
    {
        public LifePlanet(string name, int moonSize = 1) : base(name, moonSize)
        {
            var updatedSides = new List<PlanetSide>();
            foreach (var side in Sides)
            {
                var planetSide = new LifePlanetSide(side);
                updatedSides.Add(planetSide);
            }
            this.Sides = updatedSides;
        }
    }
}
