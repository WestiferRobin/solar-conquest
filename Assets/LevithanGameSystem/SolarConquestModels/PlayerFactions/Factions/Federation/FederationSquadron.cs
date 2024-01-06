using System;

namespace SolarConquestGameModels
{
    public class FederationSquadron : ParticleSquadron, ISquadron
    {
        public FederationSquadron(FederationPrism leader, bool isFull = true): base(
            leader, 
            isFull
        ) { }
        public FederationSquadron(IHedron hedron) : base(hedron, FederationFaction.FederationFlag) { }
        public FederationSquadron() : base() { }
    }
}

