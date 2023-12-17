using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class GameBoard : IBoard
    {
        public IGame Game { get; }
        public List<IBoardLine> Board { get; }
        public GameBoard(IGame game) { 
            this.Game = game;
            this.Board = new List<IBoardLine>();
        }

        public List<IBoardLine> GetLines()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }


}
