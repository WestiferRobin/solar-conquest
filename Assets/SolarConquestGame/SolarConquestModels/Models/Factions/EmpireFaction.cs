using SoverignParticles;
using System;

namespace SolarConquestGameModels
{
    public class EmpirePrism : Prism
    {
        public EmpirePrism(IPrism prism) : base(prism) { }
        public EmpirePrism(PrismID prismID) : base(prismID) { } 
    }

    public class EmpireHedron : Hedron
    {
        public EmpireHedron(IHedron hedron) : base(hedron) { }
    }

    public class EmpireSquadron : EmpireHedron
    {
        public EmpireSquadron(IHedron hedron) : base(hedron) { }
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
