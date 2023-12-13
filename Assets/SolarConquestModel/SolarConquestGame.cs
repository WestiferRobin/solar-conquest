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

        public Federation Federation { get; set; }
        public Empire Empire { get; set; }

        public IGridUpdater GameBoard { get; set; }


        public SolarConquestGame(UserPlayer allyPlayer, UserPlayer enemyPlayer)
        {
            this.Federation = new Federation(
                allyPlayer.GetAvatarHedron()
            );
            this.Empire = new Empire(
                enemyPlayer.GetAvatarHedron()
            );

            this.GameBoard = new GalaxyGrid(this.Federation, this.Empire);
        }

        public void Start()
        {
            while (Federation.IsOperational() && Empire.IsOperational())
            {
                this.GameBoard.Update();
            }
        }
    }
}
