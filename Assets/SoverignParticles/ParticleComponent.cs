using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ParticleComponent : IComponent, IParticle, IModel
{
    public Particle ParticleID { get; }

    public IComponentModel ComponentModel => throw new NotImplementedException();

    public IComponentView ComponentView => throw new NotImplementedException();

    public IComponentController ComponentController => throw new NotImplementedException();

    public ParticleGameComponent(Particle particleID = Particle.Omega)
    {
        this.ParticleID = particleID;
    }
}

public class ParticleGameComponent : ParticleComponent, IGame
{
    public ParticleGame Game { get; }
    public Particle ParticleID { get; }

    public ParticleGameComponent(IGame game, Particle pid = Particle.Omega) {
        this.ParticleID = pid;
        this.Game = new ParticleGame(game, pid);
    }
}
