using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ISide
{
    int SideIndex { get; }
    Particle SideParticleIndex { get; }
}
