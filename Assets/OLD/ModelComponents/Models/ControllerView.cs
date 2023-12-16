using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{

    public class ControllerModel: IModel
    {
        ViewModel View { get; }

        public ViewModel ModelView => throw new NotImplementedException();

        public ModelController ModelController => throw new NotImplementedException();

        public ControllerModel() { }
    
    }


    public class ControllerView: ViewModel, IController
    {
        public List<IView> Views { get; set; }

        public ModelController ModelController => throw new NotImplementedException();

        public ControllerView(): base(new ControllerModel()) 
        {
            //this.Controller = new ViewController();
        }
    }
}
