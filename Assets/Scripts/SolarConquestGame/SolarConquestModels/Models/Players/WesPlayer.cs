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
                    Gender.Male,
                    BirthSign.Pisces,
                    "Wes",
                    "Webb",
                    FamilyName.Electron,
                    Particle.Lambda,
                    Particle.Delta,
                    CombatRank.Lance,
                    CombatClass.Guardian
                );

        private static PrismID evilID = new PrismID(
                    Gender.Male,
                    BirthSign.Pisces,
                    "Jod",
                    "Toth",
                    FamilyName.Quazar,
                    Particle.Theta,
                    Particle.Omega,
                    CombatRank.Captain,
                    CombatClass.Commando
                );
        public IPrism Avatar { get; }

        public WesPlayer(bool isEvil = false): base(new User("Wes", "Webb"))
        {
            if (isEvil)
            {
                this.Avatar = new FederationPrism(wesID);
            }
            else
            {
                this.Avatar = new EmpirePrism(evilID);
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
