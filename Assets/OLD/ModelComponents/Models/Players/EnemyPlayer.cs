using SolarConquest;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class EnemyPlayer : UserPlayer
    {
        public EnemyPlayer() : base(
            new PrismID(
                Gender.Male,
                BirthSign.Scorpio,
                "Zod",
                "Omega",
                FamilyName.Admin,
                Particle.Omega,
                Particle.Omega,
                CombatRank.Admin,
                CombatClass.Guardian
            )
        )
        {
        }
    }
}
