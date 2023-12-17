using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public interface IComponentModel: IModel
    {
    }

    public class ComponentModel: ViewModel, IComponentModel
    {
        public ComponentModel(IModel model, IView view): base(
            view, 
            model
        )
        { 
        }
    }


    public interface IComponentController : IController
    {
    }

    public class ComponentController : ModelController, IComponentController
    {
        public ComponentController(IModel model, IController controller): base(
            model, 
            controller
        ) 
        { 
        }
    }
    public interface IComponentView : IView
    {
    }

    public class ComponentView: ViewController, IComponentView
    {
        public ComponentView(IView view, IController controller): base(
            view, 
            controller
        ) { 
        
        }
    }

    public interface IComponent
    {
        IComponentModel ComponentModel { get; }
        IComponentView ComponentView { get; }
        IComponentController ComponentController { get; }
        //ViewModel ComponentModel { get; }
        //ModelController ComponentController { get; }
        //ViewController ComponentView { get; }
    }
}
