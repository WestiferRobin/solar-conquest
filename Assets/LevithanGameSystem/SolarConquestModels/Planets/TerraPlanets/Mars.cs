using SolarConquestGameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class Mars : LifePlanet
    {
        public Mars() : base("Mars", moonSize: 2) { }
    }
}
