using SolarConquestGameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class EmpireSquadron : ParticleHedron
    {
        public EmpireSquadron(EmpirePrism leader, bool isFull = true) : base(leader, isFull) { }
        public EmpireSquadron(IHedron hedron) : base(hedron) { }
        public EmpireSquadron() : base() { }
    }
}
