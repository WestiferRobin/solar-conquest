using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class ParticlePrismID : PrismID
    {
        public ParticlePrismID(Particle primary, Particle secondary = Particle.Delta) :
            base(primary, secondary)
        { }
    }
}
