using SolarConquestGameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class Neptune : GasPlanet
    {
        public Neptune() : base("Neptune", lifeMoonSize: 1, deadMoonSize: 0) { }
    }
}
