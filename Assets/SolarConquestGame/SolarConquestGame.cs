using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class SolarConquestGame: ParticleGame
    {
        public FederationPlayer Federation => base.MainPlayer as FederationPlayer;
        public EmpirePlayer Empire => base.OpponentPlayer as EmpirePlayer;
        public SolarConquestGame(ParticlePlayer federationPlayer, ParticlePlayer empirePlayer): base(
            new FederationPlayer(federationPlayer),
            new EmpirePlayer(empirePlayer),
            new GalaxyBoard(),
            Particle.Delta
        )
        {
            // BLINK BLINK START HERE
        }
    }
}
