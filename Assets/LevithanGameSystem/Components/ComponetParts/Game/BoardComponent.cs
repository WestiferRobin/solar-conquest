using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoverignParticles;

namespace SolarConquestGameModels
{
    public class BoardComponent: ParticleComponent
    {
        public IBoard Board { get; }

        public BoardComponent(GameBoard board): base(Particle.Delta)
        {
            this.Board = board;
        }
    }
}
