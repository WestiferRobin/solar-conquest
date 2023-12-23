using SolarConquestGameModels;
using SoverignParticles;
using System;


public class ParticleApp : IParticle, IApp
{
    public Particle ParticleID { get; }

    public ViewModel ModelView => throw new NotImplementedException();

    public ModelController ModelController => throw new NotImplementedException();

    public ParticleApp(Particle particleID)
    {
        this.ParticleID = particleID;
    }

    public bool IsRunning()
    {
        throw new NotImplementedException();
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }

    public void Tick()
    {
        throw new NotImplementedException();
    }
}
