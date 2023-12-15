using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class SolarConquestWesGame: SolarConquestGame
    {
        public SolarConquestWesGame(): base(
            new WesPlayer(),
            new EnemyPlayer()
        ) { }
    }
}
