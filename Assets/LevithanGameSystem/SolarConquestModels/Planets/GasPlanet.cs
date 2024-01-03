using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoverignParticles;

namespace SolarConquestGameModels
{
    public class GasPlanet: Planet
    {
        public GasPlanet(Particle particle, string name, int lifeMoonSize = 2, int deadMoonSize = 1) : base(particle, name, lifeMoonSize + deadMoonSize)
        {
            Build();
        }

        public override void Build()
        {
            var updatedSides = new List<PlanetSide>();
            foreach (var side in PlanetSides)
            {
                var planetSide = new GasPlanetSide(side);
                updatedSides.Add(planetSide);
            }
            this.PlanetSides = updatedSides;

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
