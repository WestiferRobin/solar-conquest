using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class GamePlayer : IPlayer, IParticle
    {
        public string FirstName => throw new NotImplementedException();

        public string LastName => throw new NotImplementedException();

        public IPrism AvatarPrism => AvatarHedron.GetPrism(ParticleID);

        public IHedron AvatarHedron { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Particle ParticleID { get; private set; }

        public IGame Game { get; private set; }

        public GamePlayer(IPlayer player, IGame game)
        {
            Game = game;
        }
    }
}
