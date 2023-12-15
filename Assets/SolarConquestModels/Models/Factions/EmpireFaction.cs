using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class EmpirePrism : Prism
    {
        public EmpirePrism(Prism prism) : base(prism) { }
    }

    public class EmpireHedron : Hedron
    {
        public EmpireHedron(Hedron hedron) : base(hedron) { }
    }

    public class EmpireSquadron : EmpireHedron
    {
        public EmpireSquadron(Hedron hedron) : base(hedron) { }
    }
    public class EmpireFaction: IFaction
    {
        public EmpireHedron leaderHedron;


        public EmpireFaction(Particle flag)
        {
            // Add all of the pices and play
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
