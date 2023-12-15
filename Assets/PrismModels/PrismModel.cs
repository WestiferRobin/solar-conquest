using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class PrismModel: IModel
    {
        public Prism Prism { get; set; }

        public PrismModel(Prism prism)
        {
            this.Prism = prism;
        }
    }
}
