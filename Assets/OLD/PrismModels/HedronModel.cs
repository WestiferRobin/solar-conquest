using SolarConquest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class HedronModel: IModel
    {
        public Hedron Hedron { get; }

        public ViewModel ModelView => throw new NotImplementedException();

        public ModelController ModelController => throw new NotImplementedException();

        public HedronModel(Hedron hedron) { 
            Hedron = hedron;
        }
    }
}
