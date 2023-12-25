using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class FederationFaction: PlayerFaction
    {
        public FederationFaction(ParticleHedron avatarHedron): base(
            avatarHedron,
            Particle.Delta,
            new List<Particle>()
            {
                Particle.Lambda,
                Particle.Alpha,
                Particle.Gamma,
                Particle.Beta
            }
        )
        { 
            foreach (var federationFlag in this.GetFlags())
            {
                var federationHedron = new FederationHedron();
                var leader = federationHedron.GetPrism(federationFlag);
                var guardian = federationHedron.GetPrism();

                var federationFaction = new FederationArchFaction(
                    new FederationPrism(leader),
                    new FederationPrism(guardian)
                );
                this.Factions[federationFlag] = federationFaction;
            }
        }
    }

    public class FederationArchFaction: IArchFaction
    {
        public FederationSquadron LeadSquadron { get; }
        public FederationSquadron GuardianSquadron { get; }

        public FederationArchFaction(FederationPrism archLeader, FederationPrism archGuardian)
        {
            this.LeadSquadron = new FederationSquadron(archLeader, true);
        }

        public bool IsOperational()
        {
            return LeadSquadron.IsAlive() && Guardian.IsAlive();
        }

        public IPrism Guardian => GuardianSquadron.GetLeadPrism();

        public IPrism Leader => LeadSquadron.GetLeadPrism();

        public void Update()
        {
            LeadSquadron.Update();
            GuardianSquadron.Update();
        }
    }

    public class FederationPrism : ParticlePrism
    {
        public FederationPrism(IPrism prism) : base(prism, Particle.Delta) { }
        public FederationPrism(PrismID pid) : base(pid) { }
        public FederationPrism(): base(Particle.Delta) { }
    }

    public class FederationHedron : ParticleHedron
    {
        public FederationHedron(FederationPrism leader, List<ParticlePrism> members): base(
            leader,
            members
        ) { }
        public FederationHedron(FederationPrism leader, bool isFull = true) : base(leader, isFull) { }
        public FederationHedron(IHedron hedron) : base(hedron) { }
        public FederationHedron() : base(Particle.Delta) { }
    }

    public class FederationSquadron : FederationHedron
    {
        public FederationSquadron(FederationPrism leader, bool isFull = true): base(leader, isFull) { }
        public FederationSquadron(IHedron hedron) : base(hedron) { }
        public FederationSquadron() : base() { }
    }

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

        public FamilyName Name { get; }


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
