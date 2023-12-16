using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public abstract class SideGrid : ISide, IGrid
    {
        private readonly Particle sideIndex;
        public int SideIndex => (int)sideIndex;
        public Particle SideParticleIndex => sideIndex;

        public IGrid Grid { get; set; }

        public SideGrid GetSideGrid() => this;


        public SideGrid(Particle index) {
            sideIndex = index;
        }

        public SideGrid(int index)
        {
            var particleArray = Enum.GetValues(typeof(Particle));
            if (index < 0 || particleArray.Length <= index) throw new ArgumentException($"{index} isn't a valid parameter for SideGrid");
            sideIndex = (Particle)particleArray.GetValue(index);
        }
    }
}
