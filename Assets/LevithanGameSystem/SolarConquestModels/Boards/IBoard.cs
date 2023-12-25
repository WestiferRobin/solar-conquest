using System.Collections.Generic;

namespace SolarConquestGameModels
{
    public interface IBoardItem
    {
        public IModel BoardModel { get; }
    }

    public interface IBoardLine
    {
        public List<IBoardItem> GetLineItems();
    }

    public interface IBoard: IModel
    {
        List<IBoardLine> GetLines();
        void Update();
    }
}
