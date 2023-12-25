using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IHedron: IParticle
{
    Dictionary<Particle, IPrism> Registry { get; set; }
    List<IPrism> Prisms { get; }

    public IPrism AddPrism(IPrism prism, Particle pid);
    public IPrism AddPrism(ParticlePrism prism);
    public IPrism GetLeadPrism();

    public IPrism RemovePrism(Particle pid);
    public IPrism GetPrism(Particle pid);
    public IPrism GetPrism();

    void Update();
    bool IsAlive();
}
