using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{

    public interface IGalaxyComponent
    {

    }

    public interface IBoardComponent
    {

    }

    public class SolarGalaxyComponent: IGalaxyComponent
    {

    }

    public class SolarBoardComponent: IBoardComponent
    {

    }


    public class SolarComponent: IGalaxyComponent, IBoardComponent
    {

        public SolarComponent(SolarHedron hedron)
        {

        }
    }


    public class SolarHedron: Hedron
    {
        public SolarHedron(): base()
        {

        }
    }
}
