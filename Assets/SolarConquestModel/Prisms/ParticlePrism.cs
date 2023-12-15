using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{

    public class ParticlePrismID: PrismID
    {
        public ParticlePrismID(Particle primary, Particle secondary = Particle.Delta) : 
            base(primary, secondary)
        { }
    }



    public class ParticlePrism: Prism
    {
        public ParticlePrism(Particle primary): base(
            new ParticlePrismID(primary)
        ) { 
        
        }

        public ParticlePrism(Particle primary, Particle secondary): base(
            new ParticlePrismID(primary, secondary)
        )
        {

        }
    }
}
