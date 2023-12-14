using SolarConquest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public interface IPlayer
    {
        public string FirstName { get; }
        public string LastName { get; }
        public Prism Avatar { get; }
        public Hedron AvatarHedron { get; set; }
    }
}
