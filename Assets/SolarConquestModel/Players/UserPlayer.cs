using SolarConquest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class UserPlayer
    {
        public string FirstName { get => Avatar.ID.FirstName; }
        public string LastName { get => Avatar.ID.LastName; }

        private Prism Avatar { get; set; }
        private Hedron UserHedron { get; set; }

        public UserPlayer(PrismID pid)
        {
            Avatar = new Prism(pid);
            UserHedron = new Hedron(Avatar);
        }

        public Prism GetAvatar()
        {
            return Avatar;
        }

        public Hedron GetAvatarHedron()
        {
            return UserHedron;
        }
    }
}
