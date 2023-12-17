using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestUnitTests.SolarConquestModelUnitTests
{
    public class PrismIDUnitTest
    {
        [Test]
        public void DefaultPrismIDTest()
        {
            /*
             
            Particle primary, 
            Particle secondary,

            FamilyName familyName = FamilyName.Admin,
            CombatRank rank = CombatRank.Admin,
            CombatClass combatClass = CombatClass.Guardian
             
             */

            Assert.Warn("TODO: DefaultPrismIDTest");
        }

        [Test]
        public void NamedPrismIDTest()
        {
            Assert.Warn("TODO: NamedPrismIDTest");
        }

        /*
         
         public PrismID(
            Particle primary, 
            Particle secondary,

            FamilyName familyName = FamilyName.Admin,
            CombatRank rank = CombatRank.Admin,
            CombatClass combatClass = CombatClass.Guardian
        )
        {
            var rand = new Random();
            this.GenderID = rand.Next() % 2 == 0 ? Gender.Male : Gender.Female;
            this.BirthID = (BirthSign) Enum.GetValues(typeof(BirthSign)).GetValue(rand.Next(12));
            this.NameID = new ParticleNameID(primary, secondary);
            this.FamilyID = familyName;
            this.RaceID = primary;
            this.FactionID = secondary;
            this.RankID = rank;
            this.CombatClassID = combatClass;
        }

        public PrismID(
            Particle primary,
            Particle secondary,

            BirthSign birthId,

            string firstName = null,
            string lastName = null,

            Gender gender = Gender.Male,
            FamilyName familyName = FamilyName.Admin,
            CombatRank rank = CombatRank.Admin,
            CombatClass combatClass = CombatClass.Guardian
        )
        {
            this.GenderID = gender;
            this.BirthID = birthId;

            if (
                string.IsNullOrEmpty(firstName) || 
                string.IsNullOrEmpty(lastName)
            )
            {
                this.NameID = new PrismNameID(firstName, lastName);
            } 
            else
            {
                this.NameID = new ParticleNameID(primary, secondary);
            }
            this.FamilyID = familyName;
            this.RaceID = primary;
            this.FactionID = secondary;
            this.RankID = rank;
            this.CombatClassID = combatClass;
        }




        public PrismID(
            Gender genderId,
            BirthSign birthId,

            string firstName,
            string lastName,
            FamilyName familyId,

            Particle raceId,
            Particle factionId,

            CombatRank rankId,
            CombatClass combatClassId
        )
        {
            this.GenderID = genderId;
            this.BirthID = birthId;
            this.NameID = new PrismNameID(firstName, lastName);
            this.FamilyID = familyId;
            this.RaceID = raceId;
            this.FactionID = factionId;
            this.RankID = rankId;
            this.CombatClassID = combatClassId;
        }
         
         */
    }
}
