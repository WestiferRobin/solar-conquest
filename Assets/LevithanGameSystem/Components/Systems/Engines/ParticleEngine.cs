using SolarConquestGameModels;
using SoverignParticles;

public class ParticleEngineComponent : EngineComponent, IParticle
{
    public Particle ParticleID { get; }

    public ParticleEngineComponent(Particle engineParticle, IEngine engine) : base(engine)
    {
        this.ParticleID = engineParticle;
    }

    public ParticleEngineComponent(ParticleEngine engine) : base(engine)
    {
        this.ParticleID = engine.ParticleID;
    }
}

public class ParticleEngine : IParticle, IEngine
{
    public Particle ParticleID { get; }

    public IApp App { get; set; }

    public ParticleEngine(Particle pid)
    {
        this.ParticleID = pid;
        this.App = null;
    }

    public ParticleEngine(IApp app, Particle pid)
    {
        this.ParticleID = pid;
        this.App = app;
    }

    public ParticleEngine(ParticleApp app)
    {
        this.ParticleID = app.ParticleID;
        this.App = app;
    }

    public void Start()
    {
        if (this.App == null) return;
        this.App.Start();
    }

    public void Stop()
    {
        if (this.App == null) return;
        this.App.Stop();
    }

    public void Tick()
    {
        if (this.App == null) return;
        this.Tick();
    }

    public bool IsRunning()
    {
        if (this.App == null) return false;
        return this.App.IsRunning();
    }

    public IApp Eject()
    {
        var app = this.App;
        this.App = null;
        return app;
    }
}
