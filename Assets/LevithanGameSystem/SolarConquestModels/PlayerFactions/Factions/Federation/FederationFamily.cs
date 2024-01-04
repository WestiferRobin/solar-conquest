using System;
using System.Collections.Generic;

namespace SolarConquestGameModels
{
    public class FederationFamily : FederationHedron, IFamily
    {
        public FederationFamily(FederationPrism parent1, FederationPrism parent2, bool isFull = false)
        {
            InitFamily(parent1, parent2, isFull);
        }

        public FederationFamily(IPrism parent1, FederationPrism parent2, bool isFull = false)
        {
            InitFamily(new FederationPrism(parent1), parent2, isFull);
        }

        public FederationFamily(FederationPrism parent1, IPrism parent2, bool isFull = false)
        {
            InitFamily(parent1, new FederationPrism(parent2), isFull);
        }

        public FederationFamily(IPrism parent1, IPrism parent2, List<IPrism> children)
        {
            InitFamily(
                new FederationPrism(parent1),
                new FederationPrism(parent2),
                false
            );
            this.Children = new();
            foreach (var prism in children)
            {
                this.Children.Add(new FederationPrism(prism));
            }
        }

        public IPrism Father { get; private set; }

        public IPrism Mother { get; private set; }

        public List<IPrism> Children { get; }

        public QuantumName Name { get; }


        public void InitFamily(FederationPrism parent1, FederationPrism parent2, bool isFull)
        {
            FederationPrism father;
            FederationPrism mother;
            if (parent1.ID.GenderID == Gender.Male && parent2.ID.GenderID == Gender.Female)
            {
                father = parent1;
                mother = parent2;
            }
            else if (parent1.ID.GenderID == Gender.Female && parent2.ID.GenderID == Gender.Male)
            {
                father = parent2;
                mother = parent1;
            }
            else throw new Exception("CANT MAKE A FAMILY FOR GAME");

            this.Father = father;
            this.Mother = mother;

            if (isFull)
            {
                for (int count = 0; count < IFamily.MaxSize; count++)
                {
                    var child = new FederationPrism(
                        father.Breed(mother, false)
                    );
                    this.AddPrism(child, child.Pid);
                    this.Children.Add(child);
                }
            }
        }
    }

}
