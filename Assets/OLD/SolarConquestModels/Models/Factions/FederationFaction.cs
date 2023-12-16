using SolarConquest;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class FederationPrism : Prism
    {
        public FederationPrism(Prism prism) : base(prism) { }
    }

    public class FederationHedron : Hedron
    {
        public FederationHedron(Hedron hedron) : base(hedron) { }
    }

    public class FederationSquadron : FederationHedron
    {
        public FederationSquadron(Hedron hedron) : base(hedron) { }
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
