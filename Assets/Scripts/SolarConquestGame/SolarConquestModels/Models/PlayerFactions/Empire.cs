using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor.Search;

namespace SolarConquestGameModels
{
    public class Empire : PlayerFaction
    {
        public Empire(IHedron avatarHedron) : base(
            avatarHedron as Hedron,
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
