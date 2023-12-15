using SolarConquest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class DeadPlanet: Planet
    {
        public DeadPlanet(string name, int moonSize = 1) : base(name, moonSize)
        {
            var updatedSides = new List<PlanetSide>();
            foreach (var side in Sides)
            {
                var planetSide = new DeadPlanetSide(side);
                updatedSides.Add(planetSide);
            }
            this.Sides = updatedSides;
        }
    }
}
