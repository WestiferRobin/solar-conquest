using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class WesPlayer: UserPlayer
    {
        private static PrismID wesID = new PrismID(
                    Particle.Lambda,
                    Particle.Delta,
                    FamilyName.Electron,
                    CombatRank.Lance,
                    CombatClass.Magi,
                    Gender.Male,
                    BirthSign.Pisces,
                    "Wes",
                    "Webb"
                );

        private static PrismID evilID = new PrismID(
                    Particle.Lambda,
                    Particle.Delta,
                    FamilyName.Electron,
                    CombatRank.Lance,
                    CombatClass.Magi,
                    Gender.Male,
                    BirthSign.Pisces,
                    "Jod",
                    "Tyranus"
                );
        public IPrism Avatar { get; }

        public WesPlayer(bool isEvil = false): base(new User("Wes", "Webb"))
        {
            if (isEvil)
            {
                this.Avatar = new EmpirePrism(evilID);
            }
            else
            {
                this.Avatar = new FederationPrism(wesID);
            }
        }
    }

    public class EvilWesPlayer: WesPlayer
    {
        public EvilWesPlayer() : base(true) { }
    }

    //public class EvilWesPlayer : UserPlayer
    //{
    //    public EvilWesPlayer() : base(
    //        new PrismID(
    //            Gender.Male,
    //            BirthSign.Scorpio,
    //            "Zod",
    //            "Omega",
    //            FamilyName.Admin,
    //            Particle.Omega,
    //            Particle.Omega,
    //            CombatRank.Admin,
    //            CombatClass.Guardian
    //        )
    //    )
    //    {
    //    }
    //}
}
