using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public interface IView
    {
        List<ViewModel> ViewModels { get; }
        List<ViewController> ViewControllers { get; }
        ViewModel ModelView { get; }

        ViewModel GetViewModel();
    }
}
