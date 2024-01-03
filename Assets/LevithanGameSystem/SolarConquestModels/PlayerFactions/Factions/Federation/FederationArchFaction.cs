using System;
using SolarConquestGameModels;

namespace SolarConquestGameModels
{
    public class FederationArchFaction : IArchFaction
    {
        public FederationSquadron LeadSquadron { get; }
        public FederationSquadron GuardianSquadron { get; }

        public FederationArchFaction(FederationPrism archLeader, FederationPrism archGuardian)
        {
            this.LeadSquadron = new FederationSquadron(archLeader, true);
        }

        public bool IsOperational()
        {
            return LeadSquadron.IsAlive() && Guardian.IsAlive();
        }

        public IPrism Guardian => GuardianSquadron.GetLeadPrism();

        public IPrism Leader => LeadSquadron.GetLeadPrism();

        public void Update()
        {
            LeadSquadron.Update();
            GuardianSquadron.Update();
        }
    }
}

