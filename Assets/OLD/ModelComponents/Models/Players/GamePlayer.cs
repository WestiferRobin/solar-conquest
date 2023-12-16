using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class GamePlayer : IPlayer, IParticle
    {
        public string FirstName => throw new NotImplementedException();

        public string LastName => throw new NotImplementedException();

        public Prism Avatar => throw new NotImplementedException();

        public Hedron AvatarHedron { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Particle ParticleID { get; internal set; }




        public IGame Game { get; internal set; }

        public GamePlayer(IPlayer player, IGame game)
        {
            Game = game;
        }
    }
}
