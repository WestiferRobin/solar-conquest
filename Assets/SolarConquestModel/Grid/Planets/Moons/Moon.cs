using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class Moon
    {
        public string Name { get; protected set; }
        public int Index { get; protected set; }
        public Moon(Moon moon)
        {
            this.Name = moon.Name;
            this.Index = moon.Index;
        }

        public Moon(string name, int index)
        {
            Name = name;
            Index = index;
        }   

        public Moon(int index)
        {
            Name = $"Moon {index}";
            Index = index;
        }

        internal void Update()
        {
            throw new NotImplementedException();
        }
    }

    public class DeadMoon: Moon
    {
        public DeadMoon(Moon moon): base(moon) { }
    }

    public class LifeMoon : DeadMoon
    {
        public LifeMoon(Moon moon): base(moon) { }
    }
}
