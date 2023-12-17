using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ParticleGame : ParticleApp, IGame
{

    public ParticleGame(IGame game, Particle particleID = Particle.Omega): base(game as IApp, particleID)
    {

    }

    public IPlayer UserPlayer { get; }
    public IPlayer OpponentPlayer { get; }

    //public ParticleGame(IPlayer userPlayer, IPlayer opponentPlayer): base(this, userPlayer)
    //{
    //    this.UserPlayer = userPlayer;
    //    this.OpponentPlayer = opponentPlayer;
    //}

    // GameEngine: IGameComponent
    public GameEngine Engine => throw new NotImplementedException();


    // MainGamePlayer: IGameComponent

    public GamePlayer MainPlayer => throw new NotImplementedException();

    public GamePrism MainAvatar => throw new NotImplementedException();

    public GameHedron MainHedron => throw new NotImplementedException();

    // GameBoard: IGameComponent

    public GameBoard Board => throw new NotImplementedException();

    public bool IsRunning()
    {
        throw new NotImplementedException();
    }

    public void Update()
    {
        throw new NotImplementedException();
    }

    // OpponentGamePlayer: IGameComponent

    public GamePlayer OpponentPlayer => throw new NotImplementedException();

    public GamePrism OpponentAvatar => throw new NotImplementedException();

    public GameHedron OpponentHedron => throw new NotImplementedException();

}
