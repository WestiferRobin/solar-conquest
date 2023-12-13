using System;
using System.Collections.Generic;
using UnityEngine.Analytics;

namespace SolarConquest
{
    public class PrismBody
    {
        public Dictionary<PrismBodyPartOld, int> Body { get; private set; }

        public PrismBody()
        {

        }
    }


    public class Prism
    {
        public PrismID ID;
        
        public PrismBody Body { get; private set; }
        // TODO: UPDATE THIS SHIT
        public Particle Pid { get; set; }
        public Particle Hid { get; set; }
        public Dictionary<Particle, int> HedronNetwork { get; private set; }
        public Dictionary<PrismSkillID, int> Skills { get; private set; }


        public string ToJson() {
            var isAliveTag = this.IsAlive() ? "alive" : "dead";
            return $"{this.ID}:{isAliveTag}";
        }

        public override string ToString()
        {
            return ToJson();
        }

        public Prism(Prism prism)
        {
            this.ID = prism.ID;
            this.Body = prism.Body;
            this.Pid = prism.Pid;
            this.Hid = prism.Hid;
            this.HedronNetwork = prism.HedronNetwork;
            this.Skills = prism.Skills;
        }

        public Prism(
            PrismID id,
            Particle pid = Particle.Mu,
            Particle hid = Particle.Mu
        )
        {
            this.Pid = pid;
            this.Hid = hid;

            this.ID = id;
            this.Body = new PrismBody();
            this.HedronNetwork = new Dictionary<Particle, int>();
            this.Skills = CreatePrismSkills();
        }

        public bool IsAlive()
        {
            //return Body[PrismBodyPartOld.Head] > 0 && Body[PrismBodyPartOld.Torso] > 0;
            return true;
        }

        public Prism Breed(Prism partner, bool isRandom=true)
        {
            if (this.ID.GenderID != partner.ID.GenderID)
            {
                var rand = new Random();
                if (isRandom && rand.Next() % 2 == 0) return null;

                var gender = (Gender) rand.Next(0, 2);
                var birthSign = (BirthSign)rand.Next(0, 12);

                var firstName = gender == Gender.Male ? this.ID.FirstName : partner.ID.FirstName;
                var lastName = gender == Gender.Female ? this.ID.LastName : partner.ID.LastName;
                var familyId = gender == Gender.Male ? this.ID.FamilyID : partner.ID.FamilyID;

                var raceId = rand.Next(0, 100) % 2 == 0 ? this.ID.RaceID : partner.ID.RaceID;
                var factionId = rand.Next(0, 100) % 2 == 0 ? this.ID.FactionID : partner.ID.FactionID;

                var combatRank = rand.Next(0, 100) % 2 == 0 ? this.ID.RankID : partner.ID.RankID;
                var combatClass = rand.Next(0, 100) % 2 == 0 ? this.ID.CombatClassID : partner.ID.CombatClassID;

                var childId = new PrismID(
                    gender,
                    birthSign,
                    firstName,
                    lastName,
                    familyId,
                    raceId,
                    factionId,
                    combatRank,
                    combatClass
                );
                return new Prism(childId);
            }
            return null;
        }

        public bool knows(Prism target)
        {
            return HedronNetwork.ContainsKey(target.Pid);
        }

        public void socialize(Prism target)
        {
            if (knows(target) && target.knows(this))
            {
                var social_limits = CalculateSocialLimits(this, target);
                var social_score = new Random().Next(social_limits.Item1, social_limits.Item2 + 1);

                HedronNetwork[target.Pid] += social_score;
                if (HedronNetwork[target.Pid] <= -100)
                    HedronNetwork[target.Pid] = -100;
                if (HedronNetwork[target.Pid] >= 100)
                    HedronNetwork[target.Pid] = 100;

                target.HedronNetwork[Pid] += social_score;
                if (target.HedronNetwork[Pid] <= -100)
                    target.HedronNetwork[Pid] = -100;
                if (target.HedronNetwork[Pid] >= 100)
                    target.HedronNetwork[Pid] = 100;
            }
            else
            {
                HedronNetwork[target.Pid] = 0;
                target.HedronNetwork[Pid] = 0;
            }
        }

        private static Dictionary<PrismBodyPartOld, int> CreatePrismBody()
        {
            return new Dictionary<PrismBodyPartOld, int>
        {
            { PrismBodyPartOld.Head, 5 },
            { PrismBodyPartOld.Torso, 7 },
            { PrismBodyPartOld.Arms, 4 },
            { PrismBodyPartOld.Legs, 4 }
        };
        }

        private static Dictionary<PrismSkillID, int> CreatePrismSkills()
        {
            var skills = new Dictionary<PrismSkillID, int>();
            foreach (PrismSkillID skill_tag in Enum.GetValues(typeof(PrismSkillID)))
            {
                skills.Add(skill_tag, 0);
            }
            return skills;
        }

        private static Tuple<int, int> CalculateSocialLimits(Prism prism1, Prism prism2)
        {
            // Implement your logic for social limits calculation here
            return Tuple.Create(0, 100);
        }
    }
}
