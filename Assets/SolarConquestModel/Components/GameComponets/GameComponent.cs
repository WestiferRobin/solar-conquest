using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class GameComponent: IComponent
    {
        public IGame Game { get; }
        public GameComponent(IGame game) { 
            this.Game = game;
        }

        public void Update()
        {
            this.Game.Update();
        }
    }
}
