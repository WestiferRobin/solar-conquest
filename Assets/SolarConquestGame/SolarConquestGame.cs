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
        //public GameComponent SolarConquestGameComponent { get; }

        //public FederationPlayer SinglePlayer { get; }
        //public FederationPrism PlayerAvatar { get => (FederationPrism) SinglePlayer.Avatar; }

        //public EmpirePlayer OpponentPlayer { get; }
        //public EmpirePrism OpponentAvatar { get => (EmpirePrism) OpponentPlayer.Avatar; }

        public SolarConquestGame(IPlayer federationPlayer, IPlayer empirePlayer) : base(federationPlayer, empirePlayer)
        {
            // BLINK BLINK START HERE
        }
    }
}
