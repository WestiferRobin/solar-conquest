using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class ModelComponent: IComponent
    {
        public ModelComponent() { }

        public IComponentModel ComponentModel => throw new NotImplementedException();

        public IComponentView ComponentView => throw new NotImplementedException();

        public IComponentController ComponentController => throw new NotImplementedException();
    }
}
