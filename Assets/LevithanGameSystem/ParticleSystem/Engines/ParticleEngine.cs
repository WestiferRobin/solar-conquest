using SolarConquestGameModels;
using SoverignParticles;

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

    public void Update()
    {
        throw new System.NotImplementedException();
    }
}
