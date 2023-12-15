using SolarConquest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.SolarConquestModel.Games
{
    public class GameBoard : IGame, IBoard
    {
        public IBoard Board { get; }
        public IGame Game { get; }

        public GameBoard(IBoard board, IGame game)
        {
            this.Board = board;
            this.Game = game;
        }


        public bool IsRunning()
        {
            return Game.IsRunning();
        }

        public void Update()
        {
            Game.Update(Board);
        }

        public void Update(IBoard board)
        {
            foreach (var boardLine in board.GetLines())
            {
                foreach (var lineItem in boardLine)
                {
                    lineItem.Update(lineItem);
                }
            }
        }

        public IEnumerable<object> GetLines()
        {
            return this.Board.GetLines();
        }
    }
}
