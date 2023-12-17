﻿using SoverignParticles;
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
        Particle Hid { get; }
        Dictionary<Particle, IHedron> HedronNetwork { get; }
        Dictionary<PrismSkillID, PrismSkill> Skills { get; }
    }
}