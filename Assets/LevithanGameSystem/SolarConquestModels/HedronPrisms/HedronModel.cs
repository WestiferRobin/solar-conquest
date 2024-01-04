using SolarConquestGameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class HedronModel: IModel
    {
        public IHedron Hedron { get; }

        public HedronModel(IHedron hedron) { 
            Hedron = hedron;
        }

        public void Update()
        {
            Hedron.Update();
        }
    }
}
