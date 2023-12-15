using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class SolarConquestGame: IGame
    {
        public GameComponent SolarConquestGameComponent { get; }

        public SolarConquestGame(IPlayer allyPlayer, IPlayer enemyPlayer)
        {
            SolarConquestGameComponent = new SolarConquestComponent(
                new SolarConquestGame(
                    allyPlayer,
                    enemyPlayer
                )
            );
        }

        public void Update()
        {
            this.SolarConquestGameComponent.Update();
        }

        public void Start()
        {
            while (IsRunning())
            {
                Update();
            }
        }

        public bool IsRunning()
        {
            return this.SolarConquestGameComponent.Game.IsRunning();
        }
    }
}
