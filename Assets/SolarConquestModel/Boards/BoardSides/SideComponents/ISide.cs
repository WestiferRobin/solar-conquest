﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public interface ISide
    {
        int SideIndex { get; }
        Particle SideParticleIndex { get; }

        SideGrid GetSideGrid();
        IGrid Grid { get; set; }
    }
}
