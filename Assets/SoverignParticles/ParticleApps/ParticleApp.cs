using SolarConquestGameModels;
using SoverignParticles;
using System;


public class ParticleApp : ParticleAppComponent, IParticle
{
    public new Particle ParticleID { get; }
    public ParticleApp(IApp app, Particle particleID = Particle.Omega) : base(app, this) 
    {
        this.ParticleID = particleID;
    }
}
