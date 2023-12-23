using SolarConquestGameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SystemComponent : ISystem, IComponent
{
    public IComponentModel ComponentModel => throw new NotImplementedException();

    public IComponentView ComponentView => throw new NotImplementedException();

    public IComponentController ComponentController => throw new NotImplementedException();
}
