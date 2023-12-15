using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class GameComponent: ModelComponent, IGame
    {
        private GameBoard Board { get; }
        private GamePlayer Player { get; }
        private GamePlayer Opponent { get; }

        public GameComponent(IGame game) {
            this.Board = new GameBoard(game);
            this.Player = new GamePlayer(game.Player);
            this.Opponent = new GamePlayer(game.Opponent);
        }

        public void Update()
        {
            this.Board.Update();

            this.Player.Update();
            
            this.Board.Update();
            
            this.Opponent.Update();
            
            this.Board.Update();
        }

        public bool IsRunning()
        {
            return Player.Avatar.IsAlive() && Opponent.Avatar.IsAlive();
        }

        public void Update(IBoard board)
        {
            throw new NotImplementedException();
        }
    }
}
