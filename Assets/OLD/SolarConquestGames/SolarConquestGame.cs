using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class AppComponent : IApp
    {
        public AppComponent Component => throw new NotImplementedException();

        public IComponentModel ComponentModel => throw new NotImplementedException();

        public IComponentView ComponentView => throw new NotImplementedException();

        public IComponentController ComponentController => throw new NotImplementedException();
    
    
    }


    public interface IApp: IComponent
    {
        AppComponent Component { get; }
    }

    public class ParticleApp: AppComponent, IParticle
    {
        public Particle ParticleID { get; }
        public ParticleApp() { }
    }

    public class ParticleGame: ParticleApp, IGame
    {

        public ParticleGame(Particle particle) 
        { 
            
        }

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

    public class SolarConquestGame: ParticleGame
    {
        //public GameComponent SolarConquestGameComponent { get; }

        //public FederationPlayer SinglePlayer { get; }
        //public FederationPrism PlayerAvatar { get => (FederationPrism) SinglePlayer.Avatar; }
        
        //public EmpirePlayer OpponentPlayer { get; }
        //public EmpirePrism OpponentAvatar { get => (EmpirePrism) OpponentPlayer.Avatar; }

        public SolarConquestGame(AIPlayer aIPlayer, AIPlayer aIPlayer1): base(aIPlayer.Avatar.Pid)  { 
        
        }

        public SolarConquestGame(IPlayer asdf, IPlayer fdsa) : base(asdf.Avatar.Pid)
        {

        }

    }
}
