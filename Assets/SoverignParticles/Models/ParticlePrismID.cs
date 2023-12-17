﻿using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class ParticlePrismID : PrismID
    {
        public ParticlePrismID(Particle primary, Particle secondary = Particle.Delta) :
            base(primary, secondary)
        { }
    }
}