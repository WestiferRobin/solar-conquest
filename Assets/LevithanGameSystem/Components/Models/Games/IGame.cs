using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class GameEngine: IEngine
    {
        public GameEngine() { }

        public ViewModel ModelView => throw new NotImplementedException();

        public ModelController ModelController => throw new NotImplementedException();

        public bool IsRunning()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void Tick()
        {
            throw new NotImplementedException();
        }
    }
    public interface IGame
    {
        // LevithanEngine: ParticleEngine: IEngine: GameEngine
        GameEngine Engine { get; }

        // FederationPlayerComponent: GamePlayerComponent
        GamePlayer MainPlayer { get; }  // FederationPlayer with Prism and Hedrons
        GamePrism MainAvatar { get; }
        GameHedron MainHedron { get; }

        // EmpirePlayerComponent: GamePlayerComponent
        GamePlayer OpponentPlayer { get; }
        GamePrism OpponentAvatar { get; }
        GameHedron OpponentHedron { get; }

        // GalaxyMapComponent: 
        GameBoard Board { get; }

        bool IsRunning();
        void Update();
    }
}
