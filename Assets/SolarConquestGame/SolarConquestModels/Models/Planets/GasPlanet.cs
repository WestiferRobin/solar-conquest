using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class GasPlanet: Planet
    {
        public GasPlanet(string name, int lifeMoonSize = 2, int deadMoonSize = 1) : base(name, lifeMoonSize + deadMoonSize)
        {
            var updatedSides = new List<PlanetSide>();
            foreach (var side in Sides)
            {
                var planetSide = new GasPlanetSide(side);
                updatedSides.Add(planetSide);
            }
            this.Sides = updatedSides;

            var updatedMoons = new List<Moon>();
            foreach (var moon in this.Moons)
            {
                var updatedMoon = new LifeMoon(moon);
                updatedMoons.Add(updatedMoon);
            }
            this.Moons = updatedMoons;
        }
    }
}
