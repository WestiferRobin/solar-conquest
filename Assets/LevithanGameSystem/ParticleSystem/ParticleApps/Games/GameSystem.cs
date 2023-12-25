using SolarConquestGameModels;
using System.Collections.Generic;


public interface IGameSystem: ISystem
{
    GameEngine Engine { get; }
    IPlayer UserPlayer { get; }
    List<IPrism> UserPrisms { get; }
    IHedron PlayerHedron { get; }
}

// Note: Unsure if this should be abstract
public class GameSystem: ISystem
{
    // ParticleEngine
    //public IEngine EngineComponenet { get => Engine; } // To View and Control
    //public IGame GameComponenet { get => EngineComponenet.Game; } // To View and Control
    //public IPlayer OwnerComponent { get => Owner; } // The User/Owner of ISystem

    public User Owner => OwnerModel.User;
    public UserPlayer OwnerModel { get; }
    public ParticleHedron OwnerHedron => (ParticleHedron) OwnerModel.AvatarHedron;
    public GameEngine Engine { get; }
    public IGame Game => Engine.Game;

    //// PlayerControllers => GameController
    //public IController UserPlayer { get; }
    //public IPrism UserAvatar { get; set; }
    //public IHedron UserHedron { get; set; }
    //public Dictionary<Particle, IController> PrismControllers { get; set; }
    //public Dictionary<Particle, IPrism> UserPrisms { get; set; }

    //// PlayerView => GameScreen
    //public IView GameView { get; set; }
    //public IView SystemView { get; set; }
    //public ViewModel View { get; set; }


    public GameSystem(UserPlayer owner, GameEngine engine)
    {
        this.OwnerModel = owner;
        this.Engine = engine;
    }

    public void LaunchGame(IGame game)
    {
        LoadGame(game);
        StartGame();
    }

    public void LoadGame(IGame game)
    {
        if (this.Engine.App != null) return;
        this.Engine.App = game;
    }

    public void StartGame()
    {
        if (this.Engine.App == this.Game)
        {
            this.Engine.Start();
        }
    }

    public IGame EjectGame()
    {
        var app = this.Engine.Eject();
        if (app is IGame game)
        {
            return game;
        }
        else return null;
    }
}
