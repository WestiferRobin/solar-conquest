using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public abstract class ViewController: ModelController, IView
    {
        public List<ViewModel> ViewModels => throw new NotImplementedException();

        public List<ViewController> ViewControllers => throw new NotImplementedException();

        public ViewController(IView view, IController controller): base(
            view.ModelView.Model,
            controller
        )
        {

        }

        public ViewController(IView view): base(view.ModelView.Model) 
        { 
        
        }
        
        public ViewController(IController controller): base(controller)
        {

        }

        public ViewModel GetViewModel()
        {
            throw new NotImplementedException();
        }
    }
}
