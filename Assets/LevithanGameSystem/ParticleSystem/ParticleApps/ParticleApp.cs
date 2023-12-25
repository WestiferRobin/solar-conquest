using SolarConquestGameModels;
using SoverignParticles;
using System;

public interface IApp: IComponent
{
    public AppModel AppModel { get; }
    public AppView AppView { get; }
    public AppController AppController { get; }

    bool IsRunning();
    void Start();
    void Stop();
}

public class AppModel: IModel
{
    public IApp App { get; }

    public AppModel(IApp app)
    {
        this.App = app;
    }
}

public class AppView: IView
{
    public IModel App { get; }

    public AppView(AppModel app)
    {
        this.App = app;
    }
}

public class AppController: IController
{
    public IModel App { get; }

    public AppController(AppModel app)
    {
        this.App = app;
    }
}


public class ParticleApp : IParticle, IApp
{
    public Particle ParticleID { get; }

    public AppModel AppModel { get; }
    public IModel Model => AppModel;

    public AppView AppView { get; }
    public IView View => AppView;

    public AppController AppController { get; }
    public IController Controller => AppController;

    private bool IsAppRunning = false;

    public ParticleApp(Particle pid)
    {
        this.AppModel = new AppModel(this);
        this.AppView = new AppView(this.AppModel);
        this.AppController = new AppController(this.AppModel);

        this.ParticleID = pid;
    }

    public ParticleApp(Particle pid, AppModel model)
    {
        this.AppModel = model;
        this.AppView = new AppView(this.AppModel);
        this.AppController = new AppController(this.AppModel);

        this.ParticleID = pid;
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

    public virtual void Tick()
    {
        throw new NotImplementedException("NEED TO MAKE A TICK FOR THIS!");
    }
}
