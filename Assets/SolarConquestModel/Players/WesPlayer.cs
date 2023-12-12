using SolarConquest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class WesPlayer: UserPlayer
    {
        public WesPlayer() : base(
            new PrismID(
                Gender.Male,
                BirthSign.Pisces,
                "Wes",
                "Webb",
                FamilyName.Electron,
                Particle.Lambda,
                Particle.Delta,
                CombatRank.Lance,
                CombatClass.Commando
            )
        ) { 
        }
    }
}
