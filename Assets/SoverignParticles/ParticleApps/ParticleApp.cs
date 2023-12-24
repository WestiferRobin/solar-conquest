using SolarConquestGameModels;
using SoverignParticles;
using System;

public class ParticleView : ViewModel
{
    public ParticleView(ParticleApp app) : base(app)
    {

    }
}

public class ParticleController: ModelController
{
    public ParticleController(ParticleApp app): base(app)
    {

    }
}


public abstract class ParticleApp : IParticle, IApp
{
    public Particle ParticleID { get; }

    public ViewModel ModelView { get; }
    public ModelController ModelController { get; }

    public ParticleView AppView => ModelView as ParticleView;
    public ParticleController AppController => ModelController as ParticleController;

    private bool IsAppRunning = false;

    public ParticleApp(Particle particleID)
    {
        this.ParticleID = particleID;
        this.ModelView = new ParticleView(this);
        this.ModelController = new ParticleController(this);
    }

    public virtual bool IsRunning()
    {
        return IsAppRunning;
    }

    public void Start()
    {
        while (IsRunning())
        {
            try
            {
                Tick();
            }
            catch
            {
                Stop();
            }
        }
    }

    public void Stop()
    {
        IsAppRunning = false;
    }

    public void Resume()
    {
        IsAppRunning = true;
    }

    public abstract void Tick();
}
