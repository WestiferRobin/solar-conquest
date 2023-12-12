using Assets.SolarConquestModel.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class SolarConquestGame
    {

        public FederationFaction Federation { get; set; }
        public EmpireFaction Empire { get; set; }

        public GalaxyGrid GameBoard { get; set; }


        public SolarConquestGame(UserPlayer allyPlayer, UserPlayer enemyPlayer)
        {
            this.Federation = new FederationFaction(
                allyPlayer.GetAvatar(),
                allyPlayer.GetAvatarHedron()
            );
            this.Empire = new EmpireFaction(
                enemyPlayer.GetAvatar(),
                enemyPlayer.GetAvatarHedron()
            );

            this.GameBoard = new GalaxyGrid(this.Federation, this.Empire);
        }

        public void Start()
        {
            while (Federation.IsAlive() && Empire.IsAlive())
            {
                this.GameBoard.Tick();
            }
        }
    }
}
