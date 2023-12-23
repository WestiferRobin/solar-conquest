using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public interface IEngine: IModel
    {
        IApp App { get; }

        void Tick();
        void Start();
        void Stop();
        bool IsRunning();
        IApp Eject();
    }

    public interface IGameEngine: IEngine
    {
        IGame Game { get; }
        IGame EjectGame();
    }

    public class EngineModel : ViewModel, IEngine, IComponentModel  
    {
        private readonly IEngine Engine;
        public IApp App => Engine.App;

        public EngineModel(IEngine engine) : base(engine) {
            this.Engine = this.Model as IEngine;
        }

        public IApp Eject()
        {
            return Engine.Eject();
        }

        public bool IsRunning()
        {
            return Engine.IsRunning();
        }

        public void Start()
        {
            Engine.Start();
        }

        public void Stop()
        {
            Engine.Stop();
        }

        public void Tick()
        {
            Engine.Tick();
        }
    }

    public class EngineController: ModelController, IEngine, IComponentController
    {
        private readonly IEngine Engine;
        public EngineController(IEngine engine) : base(engine)
        {
            this.Engine = this.Model as IEngine;
        }

        public IApp App => this.Engine.App;

        public IApp Eject()
        {
            return Engine.Eject();
        }

        public bool IsRunning()
        {
            return Engine.IsRunning();
        }

        public void Start()
        {
            Engine.Start();
        }

        public void Stop()
        {
            Engine.Stop();
        }

        public void Tick()
        {
            Engine.Tick();
        }
    }

    
    public class EngineView: ViewController, IEngine, IComponentView
    {
        private readonly IEngine Engine;
        public EngineView(IEngine engine) : base(engine.ModelView.View) { 
            this.Engine = engine;
        }

        public IApp App => this.Engine.App;

        public void Tick()
        {
            this.Engine.Tick();
        }

        public void Start()
        {
            this.Engine.Start();
        }

        public void Stop()
        {
            this.Engine.Stop();
        }

        public bool IsRunning()
        {
            return this.Engine.IsRunning();
        }

        public IApp Eject()
        {
            return Engine.Eject();
        }
    }

    public class EngineComponent : IComponent, IEngine
    {
        private readonly IEngine Engine;
        public IComponentModel ComponentModel { get; }
        public IComponentView ComponentView { get; }
        public IComponentController ComponentController { get; }

        public ViewModel ModelView => throw new NotImplementedException();

        public ModelController ModelController => throw new NotImplementedException();

        public IApp App => Engine.App;

        public EngineComponent(IEngine engine)
        {
            this.Engine = engine;
            this.ComponentModel = new EngineModel(this.Engine);
            this.ComponentView = new EngineView(this.Engine);
            this.ComponentController = new EngineController(this.Engine);
        }

        public void Tick()
        {
            this.Engine.Tick();
        }

        public void Start()
        {
            this.Engine.Start();
        }

        public void Stop()
        {
            this.Engine.Stop();
        }

        public bool IsRunning()
        {
            return this.Engine.IsRunning();
        }

        public IApp Eject()
        {
            return Engine.Eject();
        }
    }
}
