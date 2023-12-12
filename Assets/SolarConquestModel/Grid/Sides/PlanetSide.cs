using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class PlanetSide
    {
        public int SideIndex { get; }
        public PlanetSide(PlanetSide side)
        {
            this.SideIndex = side.SideIndex;
        }

        public PlanetSide(int sideIndex)
        {
            this.SideIndex = sideIndex;
        }

        internal void Update()
        {
            throw new NotImplementedException();
        }
    }

    public class DeadPlanetSide : PlanetSide
    {
        public DeadPlanetSide(PlanetSide side) : base(side)
        {

        }
    }

    public class LifePlanetSide : PlanetSide
    {
        public LifePlanetSide(PlanetSide side) : base(side)
        {

        }
    }

    public class GasPlanetSide : PlanetSide
    {
        public GasPlanetSide(PlanetSide side) : base(side)
        {

        }
    }
}
