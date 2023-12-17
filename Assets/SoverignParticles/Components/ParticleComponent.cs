using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ParticleComponent : IComponent, IParticle
{
    public Particle ParticleID { get; }

    public IComponentModel ComponentModel => throw new NotImplementedException();

    public IComponentView ComponentView => throw new NotImplementedException();

    public IComponentController ComponentController => throw new NotImplementedException();

    public ParticleComponent(Particle particleID = Particle.Omega)
    {
        this.ParticleID = particleID;
    }
}

public class ParticleGameComponent : ParticleComponent
{
    public ParticleGame Game { get; }

    public ParticleGameComponent(IGame game, Particle pid = Particle.Omega): base(pid) {
        this.Game = new ParticleGame(game, pid);
    }
}
