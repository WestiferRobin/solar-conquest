using SolarConquest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SolarConquest
{
    public class Jupiter : GasPlanet
    {
        public Jupiter(): base("Jupiter", lifeMoonSize: 3, deadMoonSize: 2) { }
    }
}
