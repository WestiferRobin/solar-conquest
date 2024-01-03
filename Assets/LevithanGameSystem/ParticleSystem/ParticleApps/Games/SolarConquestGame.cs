using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class SolarConquestGame: ParticleGame
    {
        public FederationPlayer FederationPlayer => base.MainPlayer as FederationPlayer;
        public EmpirePlayer EmpirePlayer => base.OpponentPlayer as EmpirePlayer;

        public FederationFaction Federation { get; }
        public EmpireFaction Empire { get; }

        private readonly bool coinFlip;

        public SolarConquestGame(ParticlePlayer federationPlayer, ParticlePlayer empirePlayer): base(
            new FederationPlayer(federationPlayer),
            new EmpirePlayer(empirePlayer),
            new GalaxyBoard(),
            Particle.Delta
        )
        {

            coinFlip = new Random().Next() % 2 == 0;

            
            this.Federation = new FederationFaction(
                base.MainPlayer.AvatarHedron
            );
            this.Empire = new EmpireFaction(base.OpponentPlayer.AvatarHedron);

            InitFactions();

            // TODO: APPLY FACTION TO GALAXY BOARD
            // TODO: FOR EVENTS WE NEED PIRATES & EXCHANGE WITH WEAPON TIER SYSTEM
            // TODO: Map to the Avatar's Hedron & Prism View to Control on Planet
        }

        private void InitFactions()
        {
            if (coinFlip)
            {
                this.Federation.ApplyToBoard(this.Board as GalaxyBoard, 0);
                this.Empire.ApplyToBoard(this.Board as GalaxyBoard, this.Board.GetLines().Count - 1);
            }
            else
            {
                this.Empire.ApplyToBoard(this.Board as GalaxyBoard, 0);
                this.Federation.ApplyToBoard(this.Board as GalaxyBoard, this.Board.GetLines().Count - 1);
            }
        }
    }
}
