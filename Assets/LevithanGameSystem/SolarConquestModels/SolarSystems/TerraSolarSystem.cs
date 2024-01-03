using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoverignParticles;

namespace SolarConquestGameModels
{
    public class TerraSolarSystem: SolarSystem
    {
        public TerraSolarSystem(Particle leader, List<Particle> list): base(leader)
        {
            this.OuterPlanets = new List<GasPlanet>()
            {
                new GasPlanet(list[0], "Neptune", 1, 0),
                new GasPlanet(list[1], "Saturn", 2, 1),
                new GasPlanet(leader, "Jupiter", 3, 2),
            };

            this.InnerPlanets = new List<LifePlanet>()
            {
                new LifePlanet(list[2], "Mars", 2),
                new LifePlanet(leader, "Earth", 1),
                new LifePlanet(list[3], "Venus", 0),
            };
        }
    }
}
