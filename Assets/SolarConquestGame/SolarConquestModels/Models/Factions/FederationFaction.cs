using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class FederationPrism : Prism
    {
        public FederationPrism(IPrism prism) : base(prism) { }
        public FederationPrism(PrismID pid) : base(pid) { }
    }

    public class FederationHedron : Hedron
    {
        public FederationHedron(IHedron hedron) : base(hedron) { }
    }

    public class FederationSquadron : FederationHedron
    {
        public FederationSquadron(IHedron hedron) : base(hedron) { }
    }
    public class FederationFaction: IFaction
    {
        public FederationFaction(Particle flag)
        {

        }

        public Prism GetGuardian()
        {
            throw new NotImplementedException();
        }

        public Prism GetLeader()
        {
            throw new NotImplementedException();
        }
    }
}
