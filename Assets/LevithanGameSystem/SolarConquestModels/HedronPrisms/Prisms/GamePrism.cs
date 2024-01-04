using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoverignParticles;

namespace SolarConquestGameModels
{
    public class GamePrism: ParticlePrism
    {
        public GamePrism(IPrism prism, Particle pid): base(prism, pid) { }
        public GamePrism(ParticlePrism prism): base(prism, prism.Pid) { }
    }
}
