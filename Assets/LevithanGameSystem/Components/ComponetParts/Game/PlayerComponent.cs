using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoverignParticles;

namespace SolarConquestGameModels
{
    public class PlayerComponent: GameComponent
    {
        public IPlayer Player { get; protected set; }
        public IFaction Faction { get; protected set; }
        public PlayerComponent(
            IGame game, 
            PlayerFaction faction
        ): base(
            game, Particle.Delta
        )
        {
            this.Faction = faction;
        }
    }
}
