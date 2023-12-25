using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace SolarConquestGameModels
{
    public class PrismSkill
    {
        public PrismSkillID ID { get; }
        public int Score { get; }

        public PrismSkill(PrismSkillID id, int skillScore)
        {
            this.ID = id;
            this.Score = skillScore;
        }

        public PrismSkill(PrismSkillID id) 
        {
            this.ID = id;
            this.Score = 0;
        }
    }

    public class ParticlePrism: IModel, IPrism
    {
        public PrismID ID { get; private set; }
        public Particle Pid => IParticle.FindParticle((int)ID.RaceID);
        public Particle Hid { get; set; }

        public string FirstName => this.ID.FirstName;
        public string LastName => this.ID.LastName;
        public string Name => this.ID.Name;

        public PrismBody Body { get; private set; }

        public Dictionary<Particle, IHedron> HedronNetwork { get; private set; }
        public Dictionary<PrismSkillID, PrismSkill> Skills { get; private set; }

        /*

        Prism Mapped in Particle Properties

        Weapon, Armor, Body

        Combat, Shield, MedPack

        Rank, Skill, Network
            
        */

        public ParticlePrism()
        {
            InitPrism(new ParticlePrismID());
        }

        public ParticlePrism(IPrism prism, Particle hid)
        {
            this.ID = prism.ID;
            this.Hid = hid;
            this.Body = prism.Body;
            this.HedronNetwork = prism.HedronNetwork;
            this.Skills = prism.Skills;
        }

        public ParticlePrism(Particle pid)
        {
            InitPrism(new ParticlePrismID(pid, pid));
        }

        public ParticlePrism(Particle pid, Particle hid)
        {
            InitPrism(new ParticlePrismID(pid, hid));
        }

        public ParticlePrism(ParticlePrism prism)
        {
            this.ID = prism.ID;
            this.Body = prism.Body;
            this.HedronNetwork = prism.HedronNetwork;
            this.Skills = prism.Skills;
        }

        public ParticlePrism(
            PrismID id
        )
        {
            InitPrism(id);
        }

        public void InitPrism(PrismID id)
        {
            this.ID = id;
            this.Body = new();
            this.HedronNetwork = new();

            Dictionary<PrismSkillID, PrismSkill> skills = new();
            foreach (PrismSkillID skillTag in Enum.GetValues(typeof(PrismSkillID)))
            {
                skills.Add(skillTag, new PrismSkill(skillTag));
            }
            this.Skills = skills;
        }

        public bool IsAlive()
        {
            //return Body[PrismBodyPartOld.Head] > 0 && Body[PrismBodyPartOld.Torso] > 0;
            return true;
        }

        public IPrism Breed(IPrism partner, bool isRandom=true)
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

                var pid = rand.Next(0, 100) % 2 == 0 ? this.ID.RaceID : partner.ID.RaceID;
                var hid = rand.Next(0, 100) % 2 == 0 ? this.ID.FactionID : partner.ID.FactionID;

                var combatRank = rand.Next(0, 100) % 2 == 0 ? this.ID.RankID : partner.ID.RankID;
                var combatClass = rand.Next(0, 100) % 2 == 0 ? this.ID.CombatClassID : partner.ID.CombatClassID;

                var childId = new PrismID(
                    IParticle.FindParticle((int)pid),
                    hid,
                    familyId,
                    combatRank,
                    combatClass,
                    gender,
                    birthSign,
                    firstName,
                    lastName
                );

                return new ParticlePrism(childId);
            }
            return null;
        }

        public bool Knows(IPrism target)
        {
            return HedronNetwork.ContainsKey(target.Pid);
        }

        public void Socialize(IPrism target)
        {
            if (Knows(target) && target.Knows(this))
            {
                var socialLimits = CalculateSocialLimits(this, target);
                var socialScore = new Random().Next(socialLimits.Item1, socialLimits.Item2 + 1);

                //HedronNetwork[target.Pid] += social_score;
                //if (HedronNetwork[target.Pid] <= -100)
                //    HedronNetwork[target.Pid] = -100;
                //if (HedronNetwork[target.Pid] >= 100)
                //    HedronNetwork[target.Pid] = 100;

                //target.HedronNetwork[Pid] += social_score;
                //if (target.HedronNetwork[Pid] <= -100)
                //    target.HedronNetwork[Pid] = -100;
                //if (target.HedronNetwork[Pid] >= 100)
                //    target.HedronNetwork[Pid] = 100;
            }
            else
            {
                //HedronNetwork[target.Pid] = 0;
                //target.HedronNetwork[Pid] = 0;
            }
            throw new Exception("BRO THE PRISMS CANT SOCIALIZE");
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


        public void Update()
        {
            // Do some fucking action when updating
            throw new NotImplementedException();
        }


        private static Tuple<int, int> CalculateSocialLimits(IPrism prism1, IPrism prism2)
        {
            // Implement your logic for social limits calculation here
            return Tuple.Create(0, 100);
        }
    }
}