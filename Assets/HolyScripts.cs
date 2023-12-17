using SolarConquestGameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Genisis => Exodus => Rev
public static class HolyScripts
{
    public static void IAmTheAlphaAndTheOmega(IGame game, GameSystem gameSystem)
    {
        gameSystem.LaunchGame(game);
    }

    public static void IAmTheAlphaAndTheOmega()
    {
        IAmTheAlphaAndTheOmega(
            new SolarConquestWesGame(),
            new LevithanGameSystem()
        );
    }
}
