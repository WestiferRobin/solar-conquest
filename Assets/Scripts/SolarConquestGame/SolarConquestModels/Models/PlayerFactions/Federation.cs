using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class Federation: PlayerFaction
    {
        public Federation(IHedron avatarHedron): base(
            avatarHedron as Hedron,
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
