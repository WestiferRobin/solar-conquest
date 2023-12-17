using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class GalaxyComponent: BoardComponent
    {
        public GalaxyComponent(SolarConquestGame game): base(
            new SolarConquestGameBoard(game)
        )
        { 
        }
    }
}
