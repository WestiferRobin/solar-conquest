using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class MoonSide: PlanetSide
    {
        public MoonSide(int index): base(index)
        {

        }

        public MoonSide(PlanetSide planetSide): base(planetSide) 
        { 
        }
    }
}
