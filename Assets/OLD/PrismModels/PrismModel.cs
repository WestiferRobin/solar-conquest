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

        public ViewModel ModelView => throw new NotImplementedException();

        public ModelController ModelController => throw new NotImplementedException();

        public PrismModel(Prism prism)
        {
            this.Prism = prism;
        }
    }
}
