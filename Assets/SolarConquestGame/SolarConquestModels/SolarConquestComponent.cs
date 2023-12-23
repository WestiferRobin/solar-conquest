using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class SolarConquestComponent: GameComponent
    {
        public SolarConquestComponent(SolarConquestGame game): base(game, Particle.Delta) { 
        }
    }
}
