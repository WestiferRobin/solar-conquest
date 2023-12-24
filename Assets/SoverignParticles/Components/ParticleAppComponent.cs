using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ParticleAppComponent : AppComponent, IParticle
{
    public Particle ParticleID { get; }

    public ParticleAppComponent(IApp app, Particle pid): base(app)
    {
        this.ParticleID = pid;
    }

    public ParticleAppComponent(ParticleApp app): base(app)
    {
        this.ParticleID = app.ParticleID;
    }
}

public interface IApp : IComponentModel
{
    bool IsRunning();
    void Start();
    void Stop();
    void Tick();
    void Resume();
}

public interface IAppController: IComponentController
{

}

public interface IAppView: IComponentView
{

}

public class AppComponent : IApp, IComponent
{
    public IApp App;
    public IAppController AppController;
    public IAppView AppView;

    public AppComponent(IApp app)
    {
        this.App = app;
    }

    public ViewModel ModelView => App.ModelView;

    public ModelController ModelController => App.ModelController;

    public IComponentModel ComponentModel => App;

    public IComponentView ComponentView => AppView;

    public IComponentController ComponentController => AppController;

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

    public void Resume()
    {
        throw new NotImplementedException();
    }
}