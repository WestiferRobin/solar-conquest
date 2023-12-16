using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    //public class AppComponet: AppModel, AppView, AppController
    //public class ParticleApp: ParticleAppComponent

    // SoverignGameEngine runs SolarConquestGame on ParticleGameComponent
    // - GameEngine: ParticleGameEngine => ParticleGameEngineComponent 
    // - Game: ParticleGame: SolarConquestGame => ParticleGameComponent

    // ParticleApp on ParticleEngine which it exists, viewable, and controllable
    // ParticleGame is a ParticleApp
    // SolarConquestGame is a ParticleGame

    public class GameComponent : IComponent
    {
        public IGame Game { get; }

        public GameComponent(IGame game)
        {
            this.Game = game;
        }


        public IComponentModel ComponentModel => throw new NotImplementedException();

        public IComponentView ComponentView => throw new NotImplementedException();

        public IComponentController ComponentController => throw new NotImplementedException();
    }

    public class ParticleGameComponent: GameComponent, IParticle
    {
        public Particle ParticleID { get; }
        public ParticleGameComponent(Particle particleID, IGame game): base(game)
        {
            ParticleID = particleID;
        }
    }

    public class GamePlayerComponent : ParticleGameComponent, IPlayer
    {
        public IPlayer Player { get; set; }

        public string FirstName => throw new NotImplementedException();

        public string LastName => throw new NotImplementedException();

        public Hedron AvatarHedron { get => Player.AvatarHedron; }

        public GamePlayerComponent(GamePlayer player): base(player.ParticleID, player.Game)
        {
            this.Player = player;
        }
    }
}
