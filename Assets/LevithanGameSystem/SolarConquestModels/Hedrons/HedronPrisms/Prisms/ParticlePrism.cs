using SoverignParticles;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace SolarConquestGameModels
{
    public class PrismSkill
    {
        public PrismSkillID ID { get; }
        public int Score { get; set; }

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

    public class ParticlePrism: IModel, IPrism, IParticle
    {
        public PrismID ID { get; private set; }
        public Particle Pid { get => ID.Pid; set => ID.Pid = value; }
        public Particle Hid { get => ID.Hid; set => ID.Hid = value; }

        public UnityVector Position { get; set; }
        public PrismBody Body { get; private set; }
        public Dictionary<Particle, IHedron> HedronNetwork { get; private set; }
        public Dictionary<PrismSkillID, PrismSkill> Skills { get; private set; }

        public Particle ParticleID => this.Pid;
        public string FirstName => this.ID.FirstName;
        public string LastName => this.ID.LastName;
        public string Name => this.ID.Name;
        public QuantumName FactionName => this.ID.FamilyID;


        public PrismWeapon PrimaryWeapon { get; }
        public PrismWeapon SecondaryWeapon { get; }
        //public PrismItem PackItem { get; }
        //public PrismItem GrenadeItem { get; }

        //public PrismArmor Armor { get; }

        /*

        Prism Mapped in Particle Properties

        Weapon, Armor, Body

        Combat, Shield, MedPack

        Rank, Skill, Network
            
        */

        private void Clone(ParticlePrism prism)
        {
            this.ID = prism.ID;
            this.Body = prism.Body;
            this.HedronNetwork = prism.HedronNetwork;
            this.Skills = prism.Skills;
        }

        public ParticlePrism()
        {
            InitPrism(new ParticlePrismID());
        }

        public ParticlePrism(ParticlePrism prism)
        {
            Clone(prism);
        }

        public ParticlePrism(IPrism prism, Particle pid, Particle hid, UnityVector vector = null)
        {
            this.Position = vector ?? new();
            InitPrism(prism.ID);
            this.Pid = pid;
            this.Hid = hid;
        }

        public ParticlePrism(IPrism prism, Particle pid, UnityVector vector = null)
        {
            this.Position = vector ?? new();
            InitPrism(prism.ID);
            this.Pid = pid;
            this.Hid = pid;
        }

        public ParticlePrism(Particle pid, Particle hid, UnityVector vector = null)
        {
            this.Position = vector ?? new();
            InitPrism(new ParticlePrismID(pid, hid));
            this.Pid = pid;
            this.Hid = hid;
        }

        public ParticlePrism(Particle pid, UnityVector vector = null)
        {
            this.Position = vector ?? new();
            InitPrism(new ParticlePrismID(pid, pid));
            this.Pid = pid;
            this.Hid = pid;
        }

        public ParticlePrism(PrismID id, UnityVector vector = null)
        {
            this.Position = vector ?? new();
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

        public int UseWeapon()
        {
            return 1;
        }

        public void UseArmor(int attackScore)
        {
            var asdf = attackScore;
        }

        public bool InRange(IPrism target)
        {
            return InRange(target.Position);
        }

        public bool InRange(UnityVector position)
        {
            var asdf = this.Position.CalculateMagnitude(position);

            return true;
        }

        public void Attack(IPrism target)
        {
            // TODO: Need to implement if prism is in range.
            if (target.Dodge())
            {
                var attackScore = this.UseWeapon();
                target.Defend(attackScore);
                if (!target.IsAlive())
                {
                    this.Skills[PrismSkillID.Combat].Score += 1;
                }
            }
            /*

            if not target.dodge():
                fire_score = self.fire_weapon()
                print(f"{self} fires weapon: {fire_score}")
                target.defend(fire_score)
                if not target.is_alive():
                    self.skills[PrismSkillID.Combat].add_point()
                    print(f'{target} is dead')
                else:
                    print(f'{target} is still alive')
            else:
                print(f"{target} not in range")
            
            */
        }

        public void Defend(int attackScore)
        {
            throw new NotImplementedException();
            /*
                if body_part is None:
                    body_part = choice(list(self.body.keys()))

                damage_remain = self.armor.defend(damage_score, body_part.name)
                if damage_remain > 0:
                    self.body[body_part] -= damage_remain
                    if self.body[body_part] <= 0:
                        self.body[body_part] = 0
            */
        }

        public bool Dodge()
        {
            if (IsAlive())
            {
                return new System.Random().Next(0, 100) % 2 == 0;
            }
            else return false;
        }

        public IPrism Breed(IPrism partner, bool isRandom=true)
        {
            if (this.ID.GenderID != partner.ID.GenderID)
            {
                var rand = new System.Random();
                if (isRandom && rand.Next() % 2 == 0) return null;

                var gender = (Gender) rand.Next(0, 2);
                var birthSign = (ZodiacSign)rand.Next(0, 12);

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
                var socialScore = new System.Random().Next(socialLimits.Item1, socialLimits.Item2 + 1);

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

        public void Move(UnityVector position)
        {
            if (InRange(position))
            {
                this.Position = position;
            }
        }
    }
}
