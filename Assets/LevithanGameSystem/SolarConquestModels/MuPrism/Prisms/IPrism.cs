using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SolarConquestGameModels
{
    public interface IPrism
    {
        PrismID ID { get; }
        string FirstName { get; }
        string LastName { get; }

        Vector3 Position { get; }
        PrismBody Body { get; }

        Particle Pid { get; }
        Particle Hid { get; set; }

        FamilyName FactionName { get; }

        Dictionary<Particle, IHedron> HedronNetwork { get; }
        Dictionary<PrismSkillID, PrismSkill> Skills { get; }

        void InitPrism(PrismID id);

        bool IsAlive();

        bool InRange(IPrism target);
        void Attack(IPrism target);
        void Defend(int attackScore);
        bool Dodge();

        IPrism Breed(IPrism partner, bool isRandom);
        bool Knows(IPrism target);
        void Socialize(IPrism target);
        void Move(Vector3 position);

        void Update();
    }
}
