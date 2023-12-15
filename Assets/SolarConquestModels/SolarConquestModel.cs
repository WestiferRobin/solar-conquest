using SolarConquest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class SolarConquestModel
    {
        public SolarConquestGame Game { get; }
        public SolarConquestModel(SolarConquestGame game) { 
            this.Game = game;
        }
    }
}
