using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class SolarConquestWesGame: SolarConquestGame
    {
        public SolarConquestWesGame(): base(
            new WesPlayer(),
            new EvilWesPlayer()
        ) { }
    }
}
