using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class GalaxyBoard : GameBoard<SolarSystem>
    {
        //private readonly IPolygon GalaxyMap= new ParticlePolygon(); NOTE: THIS IS THE GOAL
        
        public GalaxyBoard(int width = 6, int height = 6): base()
        {
            var galaxyBoard = new List<GameBoardLine<SolarSystem>>();
            for (int y = 0; y < height; y += 1)
            {
                var solarLine = new GameBoardLine<SolarSystem>();
                for (int x = 0; x < width; x += 1)
                {
                    var solarSystem = new SolarSystem(Particle.Mu);
                    solarLine.AddItem(solarSystem);
                }
                galaxyBoard.Add(solarLine);
            }

            this.Board = galaxyBoard;
        }
    }

    public class SolarConquestBoard: GalaxyBoard
    {
        public FederationFaction Federation { get; }
        public EmpireFaction Empire { get; }

        public SolarConquestBoard(
            FederationFaction federation,
            EmpireFaction empire
        ): base() {
            this.Federation = federation;
            this.Empire = empire;

            InitFactions();
        }

        private void InitFactions()
        {
            for (int index = 0; index < this.Board.Count / 2; index++)
            {
                int fedIndex = index;
                int empIndex = this.Board.Count - index - 1;

                if (fedIndex == 0)
                {
                    this.Federation.ApplyToBoard(this, fedIndex);
                    this.Empire.ApplyToBoard(this, empIndex);
                }
                else
                {

                }
            }
        }

        public new void Update()
        {
            base.Update();

            this.Federation.Update();
            this.Empire.Update();
        }
    }
}
