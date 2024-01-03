using SolarConquestGameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Genisis => Exodus => Rev
namespace Levithan
{
    public static class HolyScripts
    {
        public static void IAmTheAlphaAndTheOmega(IGame game, GameSystem gameSystem)
        {
            gameSystem.LaunchGame(game);
        }

        public static void IAmTheAlphaAndTheOmega()
        {
            var system = new LevithanGameSystem();
            var game = system.EjectGame();
            IAmTheAlphaAndTheOmega(game, system);
        }
    }
}
