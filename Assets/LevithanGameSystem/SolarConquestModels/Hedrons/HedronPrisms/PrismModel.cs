using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class PrismModel: IModel
    {
        public IPrism Prism { get; set; }

        public PrismModel(IPrism prism)
        {
            this.Prism = prism;
        }

        public void Update()
        {
            this.Prism.Update();
        }
    }
}
