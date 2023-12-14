using SolarConquest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    public class SolarConquestWesGame : SolarConquestGame
    {
        public SolarConquestWesGame(Particle allyAi = Particle.Delta, Particle enemyAi = Particle.Omega) : base(
            new AIPlayer(allyAi),
            new AIPlayer(enemyAi)
        )
        { }
    }
}
