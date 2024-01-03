using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoverignParticles;

namespace SolarConquestGameModels
{
    public class AdminSolarSystem : TerraSolarSystem
    {
        public AdminSolarSystem(Particle leader, List<Particle> list) : base(leader, list)
        {
        }
    }
}
