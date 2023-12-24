using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolarConquestGameModels;

public interface IComponent
{
    IModel Model { get; }
    IView View { get; }
    IController Controller { get; }
}
