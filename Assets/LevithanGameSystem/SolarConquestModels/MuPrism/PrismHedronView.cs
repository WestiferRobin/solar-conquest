using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TODO: Implement these endpoint controllers into mu-prism => Make a gobal Hedron API for Python, Java, C#, C/C++, and JavaScript
namespace SolarConquestGameModels
{
    public class PrismViewController: IController, IView
    {
        public IPrism Prism { get; }

        public PrismViewController(IPrism model)
        {
            this.Prism = model;
        }

        public void Update()
        {
            Prism.Update();
        }
    }

    public class HedronViewController: IController, IView
    {
        public IHedron Hedron { get; }
        public List<PrismViewController> PrismControllers { get; }

        public HedronViewController(IHedron hedron)
        {
            this.Hedron = hedron;
            this.PrismControllers = new();

            foreach (var pid in this.Hedron.Registry.Keys)
            {
                var prism = this.Hedron.Registry[pid];
                var viewController = new PrismViewController(prism);
                this.PrismControllers.Add(viewController);
            }
        }

        public void Update()
        {
            Hedron.Update();
        }
    }
}
