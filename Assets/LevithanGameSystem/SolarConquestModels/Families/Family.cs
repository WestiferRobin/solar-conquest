using SolarConquestGameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class Family
    {
        public IPrism Father { get; private set; }
        public IPrism Mother { get; private set; }
        public List<IPrism> Children { get; private set; }

        public Family(IPrism father, IPrism mother, List<IPrism> children = null)
        {
            this.Father = father;
            this.Mother = mother;
            this.Children = children ?? new List<IPrism>();
        }

        public Family(IPrism father, IPrism mother, int childCount) {
            this.Father = father;
            this.Mother = mother;

            var children = new List<IPrism>();
            while (children.Count <= childCount)
            {
                var child = father.Breed(mother, isRandom: false);
                children.Add(child);
            }
            this.Children = children;
        }
    }
}
