using SolarConquestGameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class Saturn : GasPlanet
    {
        public Saturn() : base("Saturn", lifeMoonSize: 2, deadMoonSize: 1) { }
    }
}
