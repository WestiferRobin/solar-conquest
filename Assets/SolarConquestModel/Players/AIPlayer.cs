using SolarConquest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class AIPlayer: IPlayer
    {
        public string FirstName { get => Avatar.ID.FirstName; }
        public string LastName { get => Avatar.ID.LastName; }

        public Prism Avatar { get { return this.AvatarHedron.GetPrism(this.AvatarHedron.LeadParticle); } }
        public Hedron AvatarHedron { get; set; }

        public AIPlayer(Particle firstName, Particle lastName) {
            var rand = new Random();

            var prismId = new PrismID(
                rand.Next() % 2 == 0 ? Gender.Male : Gender.Female,
                GetBirthSign(rand),
                Enum.GetName(typeof(Particle), firstName),
                Enum.GetName(typeof(Particle), lastName),
                FamilyName.Admin,
                firstName,
                lastName,
                CombatRank.Admin,
                GetCombatClass(rand)
            );
        }

        private BirthSign GetBirthSign(Random rand)
        {
            var signIndex = rand.Next(0, Enum.GetValues(typeof(BirthSign)).Length);

            var asdf = Enum.GetValues(typeof(BirthSign)).GetValue(signIndex);
            return (BirthSign)asdf;
        }

        private CombatClass GetCombatClass(Random rand)
        {
            var signIndex = rand.Next(0, Enum.GetValues(typeof(CombatClass)).Length);

            var asdf = Enum.GetValues(typeof(CombatClass)).GetValue(signIndex);
            return (CombatClass)asdf;
        }
    }
}
