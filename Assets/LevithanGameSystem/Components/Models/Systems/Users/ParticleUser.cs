using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ParticleUser: User
{
    public ParticleUser(Particle pid, Particle hid) : base(
        Enum.GetName(typeof(Particle), pid), 
        Enum.GetName(typeof(Particle), hid)
    )
    {

    }

    public Particle ParticleID { get; internal set; }
}
