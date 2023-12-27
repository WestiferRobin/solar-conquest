using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class GameBoardItem : IBoardItem
    {
        public GameBoard Model;
        public GameBoardItem(GameBoard board)
        {

        }

        public IModel BoardModel => Model;

        public void Update()
        {
            Model.Update();
        }
    }

    public class GameBoardLine : IBoardLine
    {
        public List<GameBoardItem> GameBoardItems { get; }

        public GameBoardLine()
        {
            this.GameBoardItems = new();
        }

        public List<IBoardItem> GetLineItems()
        {
            List<IBoardItem> boardItems = new();
            foreach (var item in GameBoardItems)
            {
                boardItems.Add(item);
            }
            return boardItems;
        }

        public void Update()
        {
            foreach (var item in GameBoardItems)
            {
                item.Update();
            }
        }
    }

    public class GameBoard : IBoard
    {
        public List<GameBoardLine> Board { get; }


        public GameBoard(int width = 5, int height = 5) { 
            this.Board = new();
            for (int x = 0; x < width; x++)
            {
                var boardLine = new GameBoardLine();
                for (int y = 0; y < height; y++)
                {
                    boardLine.GameBoardItems.Add(new GameBoardItem(this));
                }
            }
        }

        public GameBoard(List<GameBoardLine> board)
        {
            this.Board = board;
        }

        public List<IBoardLine> GetLines()
        {
            List<IBoardLine> boardLine = new();
            foreach (var line in Board)
            {
                boardLine.Add(line);
            }
            return boardLine;
        }

        public void Update()
        {
            foreach (var line in Board)
            {
                line.Update();
            }
        }
    }


}
