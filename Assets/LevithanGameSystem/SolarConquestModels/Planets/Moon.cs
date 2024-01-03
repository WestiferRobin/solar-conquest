using Assets.SolarConquestModel.GameBoard.Planets;
using System;
using System.Collections.Generic;

namespace SolarConquestGameModels
{
    public abstract class Moon
    {
        public static int MaxSides = 6;

        public string Name { get; protected set; }
        public List<MoonSide> Sides { get; protected set; }

        public Moon(string name)
        {
            var moonSides = new List<MoonSide>();
            for (int index = 0; index < MaxSides; index++)
            {
                var moonSide = new MoonSide(index);
                moonSides.Add(moonSide);
            }
            this.Sides = moonSides;
            this.Name = name;
        }

        public Moon(Moon moon)
        {
            this.Name = moon.Name;
            this.Sides = moon.Sides;
        }

        public void Update()
        {
            foreach (var side in this.Sides)
            {
                side.Update();
            }
        }
    }

    public class DeadMoon: Moon
    {
        public DeadMoon(string name): base(name) { }
        public DeadMoon(Moon moon): base(moon) { }
    }

    public class LifeMoon : DeadMoon
    {
        public LifeMoon(string name): base(name) { }
        public LifeMoon(Moon moon): base(moon) { }
    }
}
