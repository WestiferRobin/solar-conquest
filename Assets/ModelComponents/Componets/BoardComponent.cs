using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class BoardComponent: GameComponent
    {
        public IBoard Board { get; }
        public BoardComponent(IGame game, GameBoard gameBoard): base(game)
        {
            this.Board = gameBoard;
        }
    }
}
