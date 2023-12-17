using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IGameSystem: ISystem
{
    GameEngine Engine { get; }
    IPlayer UserPlayer { get; }
    List<Prism> UserPrisms { get; }
    IHedron PlayerHedron { get; }
}

public class GameSystemComponenet: GameComponent, IGameSystem
{
    public GameSystemComponenet() { }
}


public class GameSystem: ISystem
{
    // ParticleEngine
    public IEngine EngineComponenet { get; } // To View and Control
    public IGame GameComponenet { get; } // To View and Control
    public IPlayer OwnerComponent { get; set; } // The User/Owner of ISystem

    public GameEngine Engine => throw new NotImplementedException();

    public IPlayer UserPlayer => throw new NotImplementedException();

    public List<Prism> UserPrisms => throw new NotImplementedException();

    public IHedron PlayerHedron => throw new NotImplementedException();


    //// PlayerControllers
    //public IController UserPlayer { get; }
    //public IPrism UserAvatar { get; set; }
    //public IHedron UserHedron { get; set; }
    //public Dictionary<Particle, IController> PrismControllers { get; set; }
    //public Dictionary<Particle, IPrism> UserPrisms { get; set; }

    //// PlayerView
    //public IView GameView { get; set; }
    //public IView SystemView { get; set; }
    //public ViewModel View { get; set; }

    public GameSystem(IGame game, bool initLaunch = false)
    {
        if (initLaunch)
        {
            LaunchGame(game);
        }
        else
        {
            LoadGame(game);
        }
    }

    public void LaunchGame(IGame game)
    {
        LoadGame(game);
        StartGame();
    }

    public void LoadGame(IGame game)
    {
        // Load game into Component so LoadGameComponent
        // use the GameSystemModelComponent => GameSystemComponent: ModelComponent
        // GameSystemComponent: ModelComponent => uses GameSystemModel
        // And SolarConquestModel in SolarConquestGame so SolarConquestModelComponent: ModelComponent
        // Which means GameSystemModelComponent: ModelComponent and SolarConquestModelComponent: ModelComponent
        // Thus SolarConquestModelComponent: GameSystemModelComponent: ModelComponent

        // Then Levithan:ParticleEngine:ParticleApp => ParticleGame:SolarConquest
        // Now Levithan:ParticleEngine:ParticleApp:SolarConquest
        // Which means Levithan:SolarConquest with GameSystemComponents: ModelComponents
    }

    public void StartGame()
    {
        // use the GameSystemEngineComponent to use IEngine
    }
}
