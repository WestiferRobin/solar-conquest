using SolarConquest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class UserPlayer : IPlayer
    {
        public string FirstName { get => Avatar.ID.FirstName; }
        public string LastName { get => Avatar.ID.LastName; }

        public Prism Avatar { get { return this.AvatarHedron.GetPrism(this.AvatarHedron.LeadParticle); } }
        public Hedron AvatarHedron { get; set; }

        public UserPlayer(PrismID pid)
        {
            AvatarHedron = new Hedron(new Prism(Avatar));
        }
    }
}
