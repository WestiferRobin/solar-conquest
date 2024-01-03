using System;
using SoverignParticles;

namespace SolarConquestGameModels
{
    public class FederationPrism : ParticlePrism
    {
        public FederationPrism(IPrism prism) : base(prism, Particle.Delta) { }
        public FederationPrism(PrismID pid) : base(pid) { }
        public FederationPrism() : base(Particle.Delta) { }
    }
}

