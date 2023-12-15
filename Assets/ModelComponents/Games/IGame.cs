using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public interface IGame
    {
        bool IsRunning();
        void Update();
        void Update(IBoard board);
    }
}
