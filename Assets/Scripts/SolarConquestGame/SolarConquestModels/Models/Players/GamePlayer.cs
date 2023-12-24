using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class ParticlePlayer: IParticle, IPlayer
    {
        public IPrism AvatarPrism { get; set; }
        public IHedron AvatarHedron { get; set; }
        public string FirstName { get => AvatarPrism.FirstName; }
        public string LastName { get => AvatarPrism.LastName; }

        public ParticlePlayer(Particle pid){
            this.ParticleID = pid;
        }

        protected ParticlePlayer(IPrism prism)
        {
            this.AvatarPrism = prism;
            this.AvatarHedron = new SinglePrismHedron(this.AvatarPrism as Prism);
        }

        public Particle ParticleID { get; }
    }

    public class GamePlayer : ParticlePlayer
    {
        public GamePlayer(Particle pid): base(pid)
        {
        }

        public void Update()
        {
            base.AvatarHedron.Update();
        }
    }
}
