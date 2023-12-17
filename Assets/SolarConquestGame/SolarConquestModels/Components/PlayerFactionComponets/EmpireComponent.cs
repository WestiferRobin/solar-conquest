using SolarConquestGameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EmpireComponent : PlayerComponent
{
    public EmpireComponent(SolarConquestGame game, IPlayer player) : base(
        game,
        new Empire(player.AvatarHedron)
    )
    {
    }
}
