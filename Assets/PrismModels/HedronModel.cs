using SolarConquest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.PrismModels
{
    public class HedronModel: IModel
    {
        public Hedron Hedron { get; }
        public HedronModel(Hedron hedron) { 
            Hedron = hedron;
        }
    }
}
