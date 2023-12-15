using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class BoardSide: IBoard, ISide
    {
        public IBoard Board;
        public ISide Side;

        public BoardSide(IBoard board, ISide side) { 
            this.Board = board;
            this.Side = side;
        }

        public int SideIndex => Side.SideIndex;

        public Particle SideParticleIndex => Side.SideParticleIndex;

        public IEnumerable<object> GetLines()
        {
            return Board.GetLines();
        }
    }
}
