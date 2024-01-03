using System.Collections.Generic;

namespace SolarConquestGameModels
{
    public interface IBoardItem: IModel
    {
        public IModel ItemModel { get; }
    }

    public interface IBoardLine: IModel
    {
        public List<IBoardItem> GetLineItems();
    }

    public interface IBoard: IModel
    {
        List<IBoardLine> GetLines();
    }
}
