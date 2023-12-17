using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class ParticleNameID : PrismNameID
    {
        public ParticleNameID(Particle pid, Particle hid) : base(
            Enum.GetName(typeof(Particle), pid),
            Enum.GetName(typeof(Particle), hid)
        )
        {

        }
    }
}
