using SolarConquest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class Family
    {
        public Prism Father { get; private set; }
        public Prism Mother { get; private set; }
        public List<Prism> Children { get; private set; }

        public Family(Prism father, Prism mother, List<Prism> children = null)
        {
            this.Father = father;
            this.Mother = mother;
            this.Children = children ?? new List<Prism>();
        }

        public Family(Prism father, Prism mother, int childCount) {
            this.Father = father;
            this.Mother = mother;

            var children = new List<Prism>();
            while (children.Count <= childCount)
            {
                var child = father.Breed(mother, isRandom: false);
                children.Add(child);
            }
            this.Children = children;
        }
    }
}
