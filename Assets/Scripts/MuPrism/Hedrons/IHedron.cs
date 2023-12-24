using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IHedron
{
    Dictionary<Particle, IPrism> Registry { get; set; }
    List<IPrism> Prisms { get; }
    public Particle LeadParticle { get; set; }

    public IPrism AddPrism(IPrism prism, Particle pid);
    public IPrism AddPrism(ParticlePrism prism);

    public IPrism RemovePrism(Particle pid);
    public IPrism GetPrism(Particle pid);
    public IPrism GetLeadPrism();
    void Update();
    bool IsAlive();
}
