using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public interface IFleet
    {
        public IShip GetLeaderShip();
        public IShip GetPrimarySupportShip();
        public IShip GetSecondarySupportShip();
        void Update();
    }
}
