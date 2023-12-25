using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public interface IPrism
    {
        PrismID ID { get; }
        string FirstName { get; }
        string LastName { get; }
        PrismBody Body { get; }
        Particle Pid { get; }
        Particle Hid { get; set; }
        Dictionary<Particle, IHedron> HedronNetwork { get; }
        Dictionary<PrismSkillID, PrismSkill> Skills { get; }

        void InitPrism(PrismID id);

        bool IsAlive();
        IPrism Breed(IPrism partner, bool isRandom);
        bool Knows(IPrism target);
        void Socialize(IPrism target);

        void Update();
    }
}
