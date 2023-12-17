using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ParticleAppComponent : ParticleComponent
{
    public ParticleApp App { get; }

    public ParticleAppComponent(IApp app, Particle pid = Particle.Omega)
    {
        this.App = new ParticleApp(app, pid);
    }

    public ParticleAppComponent(ParticleApp app) : base(app.ParticleID)
    {
        this.App = app;
    }
}

public interface IApp : IComponentModel
{
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
}