using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public struct PrismID
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public Particle RaceID { get; set; }
        public Particle FactionID { get; set; }
        public FamilyName FamilyID { get; set; }
        public Gender GenderID { get; set; }
        public BirthSign BirthID { get; private set; }
        public CombatRank RankID { get; set; }
        public CombatClass CombatClassID { get; set; }

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
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FamilyID = familyId;
            this.RaceID = raceId;
            this.FactionID = factionId;
            this.RankID = rankId;
            this.CombatClassID = combatClassId;
        }


        public readonly string ToJson()
        {
            var asdf = new Dictionary<string, string>() {
                { "GenderID", this.GenderID.ToString() },
                { "BirthID", this.BirthID.ToString() },
                { "FirstName", this.FirstName.ToString() },
                { "LastName", this.LastName.ToString() },
                { "FamilyID", this.FamilyID.ToString() },
                { "RaceID", this.RaceID.ToString() },
                { "FactionID", this.FactionID.ToString() },
                { "RankID", this.RankID.ToString() },
                { "CombatClassID", this.CombatClassID.ToString() }
            };
            return asdf.ToString();
        }

        public override string ToString()
        {
            return ToJson();
        }
    }
}
