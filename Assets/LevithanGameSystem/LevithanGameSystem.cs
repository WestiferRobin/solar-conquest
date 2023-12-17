using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ParticleGameSystem: GameSystem, IParticle
{
    public Particle ParticleID { get; }

    public ParticleGameSystem(Particle particle, ParticleGame game): base(game)
    {
        this.ParticleID = particle;
    }
}


public class LevithanGameSystem: ParticleGameSystem
{
    public LevithanGameSystem(): base(Particle.Omega, new SolarConquestWesGame()) { }
    public LevithanGameSystem(SolarConquestGame game) : base(Particle.Omega, game) { }
}
