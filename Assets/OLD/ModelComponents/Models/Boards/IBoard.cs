using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public interface IBoardItem
    {
        public IModel BoardModel { get; }
    }

    public interface IBoardLine
    {
        public List<IBoardItem> GetLineItems();
    }

    public interface IBoard
    {
        List<IBoardLine> GetLines();
        void Update();
    }
}
