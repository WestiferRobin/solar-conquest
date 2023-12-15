using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class GameBoard: IGame, IBoard
    {
        private IGame Game { get; }

        public GameBoard(IGame game) 
        { 
            this.Game = game;
        }

        public bool IsRunning()
        {
            return Game.IsRunning();
        }

        public void Update()
        {
            Game.Update();
        }
    }
}
