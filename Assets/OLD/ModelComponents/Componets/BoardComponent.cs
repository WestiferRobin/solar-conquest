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

        public BoardComponent(GameBoard board): base(board.Game)
        {
            this.Board = board;
        }
    }
}
