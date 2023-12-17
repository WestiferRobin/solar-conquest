using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TODO: Implement these endpoint controllers into mu-prism => Make a gobal Hedron API for Python, Java, C#, C/C++, and JavaScript
namespace SolarConquestGameModels
{
    public class PrismHedronViewController: ViewController
    {
        public PrismHedronViewController(Hedron prismHedron) : base(prismHedron.ModelView.View)
        {

        }
    }

    public class HedronViewController: PrismHedronViewController
    {
        public HedronViewController(Hedron hedron) : base(hedron) 
        { 
        
        }
    }

    //public class PrismViewController: ViewController 
    //{ 
    //    public PrismViewController(Prism prism): base(
    //        prism.ModelView.View, 
    //        new PrismControllerComponent
    //    )
    //    {

    //    }
    //}
}
