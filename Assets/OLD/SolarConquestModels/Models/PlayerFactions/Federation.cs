using SolarConquest;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class Federation: PlayerFaction
    {
        public Federation(Hedron avatarHedron): base(
            avatarHedron,
            Particle.Delta,
            Particle.Lambda,
            Particle.Alpha,
            Particle.Gamma,
            Particle.Beta
        )
        { 
            foreach (var federationFlag in this.GetFlags())
            {
                var federationFaction = new FederationFaction(federationFlag);
                this.Factions[federationFlag] = federationFaction;
            }
        }
    }
}
