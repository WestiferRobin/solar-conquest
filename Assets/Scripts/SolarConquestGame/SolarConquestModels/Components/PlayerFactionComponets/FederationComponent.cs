using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class FederationComponent : PlayerComponent
    {
        public FederationComponent(SolarConquestGame game, IPlayer player) : base(
            game,
            new Federation(player.AvatarHedron)
        )
        {
        }
    }
}
