using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GameEngine : ParticleEngine
{
    public GameEngine(Particle pid) : base(pid) { }

    public IGame Game => this.App as IGame;
}

public interface IGameSystem: ISystem
{
    GameEngine Engine { get; }
    IPlayer UserPlayer { get; }
    List<Prism> UserPrisms { get; }
    IHedron PlayerHedron { get; }
}

public class GameSystemComponenet: GameComponent //, IGameSystem
{
    public GameSystemComponenet(): base(null, Particle.Delta) { }
}

/*
 
Levithan Game System => GameSystem adapter to Unity game engine for Solar Conquest

Unity => Solar Conquest

Levithan => Solar Conquest

Make the game
Use the adapter to make Hedron.com and Prism.ai


--------------------------------------------------

Levithan: GameSystem that plays Game: SolarConquest

Levithan.getEngine() => SoverignEngine: ParticleEngine: GameEngine: GameSystemComponent => SoverignEngineSystemComponent
SolarConquest: ParticleGame: ParticalApp

GameEngine.loadsGame(solarConquest)
LevithanScreen: GameEngineView
HedronController: ParticleController for PrismController: ParticleController

therefore:
    LevithanSystem: GameSystem
        - ParticleEngine Component
        - ParticleController Component
        - ParticleScreen Component

thus story:
    Wes buys Levithan GameSystem to play SolarConquest
    Wes has a prism controller for himself and 12 other Prisms => HedronSystemController 
    Wes loads up a classic game of SolarConquest
    Wes controls his Freighter and Hedron
    Wes captures Genesis V and declares and outpost
    According to the world setup, it will have a game ai storyteller like rimworld
        - Fight the Empire
        - Take a bounty with Exchange or Priates
        - Trade with Federation and Natives
        - Visit other User Hedron Family Line => Classic game is the User's Prism lineage



 */

public abstract class GameSystem: ISystem
{
    // ParticleEngine
    //public IEngine EngineComponenet { get => Engine; } // To View and Control
    //public IGame GameComponenet { get => EngineComponenet.Game; } // To View and Control
    //public IPlayer OwnerComponent { get => Owner; } // The User/Owner of ISystem

    public GameEngine Engine { get; }

    public UserPlayer Owner { get; }

    public IGame Game => this.Engine.Game;



    public IHedron OwnerHedron => Owner.AvatarHedron;

    public List<IPrism> OwnerPrisms => Owner.AvatarHedron.Prisms;


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

    public GameSystem(UserPlayer owner, GameEngine engine)
    {
        this.Owner = owner;
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
        return null;
    }
}
