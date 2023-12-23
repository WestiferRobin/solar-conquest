using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ParticleGame : ParticleApp, IGame
{

    public GamePlayer MainPlayer { get; }

    public GamePlayer OpponentPlayer { get; }

    public GameBoard Board { get; }

    public ParticleGame(GamePlayer main, GamePlayer opponent, GameBoard board, Particle particleID): base(particleID)
    {
        this.MainPlayer = main;
        this.OpponentPlayer = opponent;
        this.Board = board;
    }


    public void Update()
    {
        this.Board.Update();

        this.MainPlayer.Update();

        this.Board.Update();

        this.OpponentPlayer.Update();

        this.Board.Update();
    }
}
