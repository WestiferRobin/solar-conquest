using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class SideComponent: ModelComponent, ISide
    {
        public ISide Side { get;  }

        public int SideIndex => Side.SideIndex;

        public Particle SideParticleIndex => Side.SideParticleIndex;

        public SideComponent(ISide side) {
            this.Side = side;
        }
    }
}
