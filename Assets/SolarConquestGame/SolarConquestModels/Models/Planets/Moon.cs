using Assets.SolarConquestModel.GameBoard.Planets;
using System;
using System.Collections.Generic;

namespace SolarConquestGameModels
{
    public abstract class Moon: Planet
    {
        public Moon(string name): base(name)
        {
            var moonSides = new List<PlanetSide>();
            foreach (var side in Sides)
            {
                var moonSide = new MoonSide(side);
                moonSides.Add(moonSide);
            }
            this.Sides = moonSides;
        }

        public Moon(Planet moon) : base(moon) { }
    }

    public class DeadMoon: Moon
    {
        public DeadMoon(string name): base(name) { }
        public DeadMoon(Planet moon) : base(moon) { }
    }

    public class LifeMoon : DeadMoon
    {
        public LifeMoon(string name): base(name) { }
        public LifeMoon(Planet moon): base(moon) { }
    }
}
