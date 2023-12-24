using Assets.SolarConquestModel.GameBoard.Sides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class MoonSideComponent: PlanetSideComponent
    {
        public MoonSideComponent(ISide side) : base(side)
        {
        }
    }
}
