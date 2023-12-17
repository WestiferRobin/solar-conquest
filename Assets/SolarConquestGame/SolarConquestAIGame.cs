using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    public class SolarConquestAIGame : SolarConquestGame
    {
        public SolarConquestAIGame(Particle allyAi = Particle.Delta, Particle enemyAi = Particle.Omega) : base(
            new AIPlayer(allyAi, Particle.Delta),
            new AIPlayer(enemyAi, Particle.Omega)
        )
        { }
    }
}
