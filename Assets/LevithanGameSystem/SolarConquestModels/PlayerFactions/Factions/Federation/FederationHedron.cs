using System;
using System.Collections.Generic;
using SoverignParticles;

namespace SolarConquestGameModels
{
    public class FederationHedron : ParticleHedron
    {
        public FederationHedron(FederationPrism leader, List<ParticlePrism> members) : base(
            leader,
            members
        )
        { }
        public FederationHedron(FederationPrism leader, bool isFull = true) : base(leader, isFull) { }
        public FederationHedron(IHedron hedron) : base(hedron) { }
        public FederationHedron(bool isFull = true) : base(Particle.Delta, isFull) { }
    }
}

