using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public abstract class ModelController: IModel, IController
    {
        public ModelController ControllerModel { get => this; }

        public IModel Model { get; private set; }
        public ViewModel ModelView => this.Model.ModelView;
        public IController Controller { get; private set; }

        ModelController IModel.ModelController => throw new NotImplementedException();

        ModelController IController.ModelController => throw new NotImplementedException();

        public ModelController(IModel model, IController controller)
        {
            this.Model = model;
            this.Controller = controller;
        }

        public ModelController(IModel model)
        {
            this.Model = model;
            this.Controller = this.Model.ModelController.Controller;
        }

        public ModelController(IController controller)
        {
            this.Controller = controller;
            this.Model = this.Controller.ModelController.Model;
        }
    }
}
