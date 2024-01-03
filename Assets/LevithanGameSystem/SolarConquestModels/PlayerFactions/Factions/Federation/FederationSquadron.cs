using System;

namespace SolarConquestGameModels
{
    public class FederationSquadron : FederationHedron
    {
        public FederationSquadron(FederationPrism leader, bool isFull = true) : base(leader, isFull) { }
        public FederationSquadron(IHedron hedron) : base(hedron) { }
        public FederationSquadron() : base() { }
    }
}

