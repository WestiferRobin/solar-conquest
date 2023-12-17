using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IHedron
{
    Dictionary<Particle, Prism> Registry { get; }

    IPrism GetLeadPrism();
    IPrism GetPrism(object leadParticle);
}
