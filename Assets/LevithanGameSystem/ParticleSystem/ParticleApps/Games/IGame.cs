using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IGame : IApp
{
    GamePlayer MainPlayer { get; }
    GamePlayer OpponentPlayer { get; }

    IBoard Board { get; }
}
