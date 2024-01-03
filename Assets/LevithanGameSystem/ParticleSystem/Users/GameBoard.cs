using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class GameBoardItem<T> : IBoardItem
    {
        public IModel ItemModel { get; }

        public T Model => (T) ItemModel;

        public GameBoardItem(T item)
        {
            this.ItemModel = item as IModel;
        }

        public GameBoardItem(IModel item)
        {
            this.ItemModel = item;
        }

        public GameBoardItem()
        {
            this.ItemModel = null;
        }

        public void Update()
        {
            if (this.ItemModel == null) throw new Exception("ASDF");
            this.ItemModel.Update();
        }
    }

    public class GameBoardLine<T> : IBoardLine
    {
        public List<GameBoardItem<T>> BoardItems { get; }

        public GameBoardLine()
        {
            this.BoardItems = new();
        }

        public List<IBoardItem> GetLineItems()
        {
            List<IBoardItem> boardItems = new();
            foreach (var item in BoardItems)
            {
                boardItems.Add(item);
            }
            return boardItems;
        }

        public void AddItem(T item)
        {
            var gameItem = new GameBoardItem<T>(item);
            BoardItems.Add(gameItem);
        }

        public void Update()
        {
            foreach (var item in BoardItems)
            {
                item.Update();
            }
        }
    }

    public class GameBoard<T> : IBoard
    {
        public List<GameBoardLine<T>> Board { get; protected set; }

        public GameBoard()
        {
            this.Board = new();
        }

        public GameBoard(int width, int height) { 
            this.Board = new();
            for (int x = 0; x < width; x++)
            {
                var boardLine = new GameBoardLine<T>();
                for (int y = 0; y < height; y++)
                {
                    boardLine.BoardItems.Add(new GameBoardItem<T>());
                }
            }
        }

        public GameBoard(List<GameBoardLine<T>> board)
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
