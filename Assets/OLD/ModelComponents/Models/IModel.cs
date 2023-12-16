using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public interface IModel
    {
        ViewModel ModelView { get; }
        ModelController ModelController { get; }
    }
}
