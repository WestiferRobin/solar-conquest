using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class DeadPlanet: Planet
    {
        public DeadPlanet(Particle particle, string name, int moonSize = 1) : base(particle, name, moonSize)
        {
            Build();
        }

        public override void Build()
        {
            var updatedSides = new List<PlanetSide>();
            foreach (var side in PlanetSides)
            {
                var planetSide = new DeadPlanetSide(side);
                updatedSides.Add(planetSide);
            }
            this.PlanetSides = updatedSides;
        }
    }
}
