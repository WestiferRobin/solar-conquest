using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ParticleGameSystem: GameSystem, IParticle
{
    public Particle ParticleID { get; }

    public ParticleGameSystem(Particle pid, UserPlayer owner, GameEngine engine): base(owner, engine)
    {
        this.ParticleID = pid;
    }

    public ParticleGameSystem(Particle pid, UserPlayer owner): base(owner, new GameEngine(pid))
    {
        this.ParticleID = pid;
    }
}


public class LevithanGameSystem: ParticleGameSystem
{
    public LevithanGameSystem() : base(
        Particle.Omega,
        new WesPlayer(),
        new SoverignEngine()
    )
    {
        this.LoadGame(
            new SolarConquestGame(
                this.OwnerModel,
                new EvilWesPlayer()
            )
        );
    }
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