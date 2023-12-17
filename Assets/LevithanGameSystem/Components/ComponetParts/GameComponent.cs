using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//public class AppComponet: AppModel, AppView, AppController
//public class ParticleApp: ParticleAppComponent

// SoverignGameEngine runs SolarConquestGame on ParticleGameComponent
// - GameEngine: ParticleGameEngine => ParticleGameEngineComponent 
// - Game: ParticleGame: SolarConquestGame => ParticleGameComponent

// ParticleApp on ParticleEngine which it exists, viewable, and controllable
// ParticleGame is a ParticleApp
// SolarConquestGame is a ParticleGame

public class GameComponent : ParticleGameComponent
{
    public IGame Game { get; set; }

    public GameComponent(IGame game, Particle pid) : base(pid) {
        this.Game = game;
    }


    public IComponentModel ComponentModel => throw new NotImplementedException();

    public IComponentView ComponentView => throw new NotImplementedException();

    public IComponentController ComponentController => throw new NotImplementedException();
}

public class GamePlayerComponent : ParticleGameComponent, IPlayer
{
    public IPlayer Player { get; set; }

    public string FirstName => AvatarPrism.FirstName;

    public string LastName => AvatarPrism.LastName;

    public IHedron AvatarHedron => Player.AvatarHedron;

    public IPrism AvatarPrism => AvatarHedron.GetLeadPrism();

    public GamePlayerComponent(GamePlayer player) : base(player.Game)
    {
        this.Player = player;
    }
}
