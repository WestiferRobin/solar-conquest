using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class ParticlePrismID : PrismID
    {
        public ParticlePrismID(Particle primary, Particle secondary) :
            base(primary, secondary)
        { }

        public ParticlePrismID(Particle primary) :
            base(primary, IParticle.GetRandom())
        { }

        public ParticlePrismID(): base(
            IParticle.GetRandom(),
            IParticle.GetRandom()
        )
        { }
    }
}
