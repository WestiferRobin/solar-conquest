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
        private static readonly PrismID guardianID = new(
                    Particle.Lambda,
                    Particle.Delta,
                    FamilyName.Electron,
                    CombatRank.Arch,
                    CombatClass.Prime,
                    Gender.Male,
                    BirthSign.Pisces,
                    "Wes",
                    "Webb"
                );

        private static readonly PrismID templarID = new(
                    Particle.Omega,
                    Particle.Omega,
                    FamilyName.Quazar,
                    CombatRank.Admin,
                    CombatClass.Prime,
                    Gender.Male,
                    BirthSign.Scorpio,
                    "Jod",
                    "Tyranus"
                );

        public IPrism Avatar { get; }

        public WesPlayer(bool isEvil = false) : base(
            new UserPrism(
                new User("Wes", "Webb"),
                isEvil ? templarID : guardianID
            )
        )
        {
            if (isEvil)
            {
                this.Avatar = new EmpirePrism(base.AvatarPrism);
            }
            else
            {
                this.Avatar = new FederationPrism(base.AvatarPrism);
            }
        }
    }

    public class EvilWesPlayer: WesPlayer
    {
        public EvilWesPlayer() : base(true) { }
    }
}
