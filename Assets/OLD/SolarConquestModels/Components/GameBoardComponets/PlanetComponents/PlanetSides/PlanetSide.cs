using Assets.SolarConquestModel.GameBoard.Sides;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class PlanetSide: ISide
    {
        public int SideIndex { get; }

        public Particle SideParticleIndex => throw new NotImplementedException();

        public IGrid Grid { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

        public SideGrid GetSideGrid()
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
