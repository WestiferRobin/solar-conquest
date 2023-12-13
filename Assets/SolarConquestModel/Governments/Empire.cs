using SolarConquest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor.Search;

namespace SolarConquest
{
    public class Empire : Government
    {
        public Empire(Hedron avatarHedron) : base(
            avatarHedron,
            Particle.Omega,
            Particle.Psi,
            Particle.Theta,
            Particle.Phi,
            Particle.Sigma
        )
        {
            foreach (var empireFlag in this.GetFlags())
            {
                var empireFaction = new EmpireFaction(empireFlag);
                this.Factions[empireFlag] = empireFaction;
            }
        }
    }
}
