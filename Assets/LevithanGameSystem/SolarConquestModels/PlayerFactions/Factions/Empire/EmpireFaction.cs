using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class EmpireFaction : PlayerFaction
    {
        public static Particle EmpireFlag = Particle.Omega;

        public EmpireFaction(IHedron hedron) : base(
            new EmpireHedron(hedron),
            EmpireFlag,
            new List<Particle>()
            {
                Particle.Psi,
                Particle.Theta,
                Particle.Phi,
                Particle.Sigma
            }
        )
        {
            Init();
        }

        public EmpireFaction(ParticleHedron avatarHedron) : base(
            avatarHedron,
            EmpireFlag,
            new List<Particle>()
            {
                Particle.Psi,
                Particle.Theta,
                Particle.Phi,
                Particle.Sigma
            }
        )
        {
            Init();
        }

        private void Init()
        {
            foreach (var empireFlag in this.GetFlags())
            {
                var empireHedron = new EmpireHedron();
                var leader = empireHedron.GetPrism(empireFlag);
                var guardian = empireHedron.GetPrism();

                var empireFaction = new EmpireArchFaction(
                    new EmpirePrism(leader),
                    new EmpirePrism(guardian)
                );
                this.Factions[empireFlag] = empireFaction;
            }
        }
    }

    public class EmpireArchFaction : IArchFaction
    {
        public EmpireSquadron LeadSquadron { get; }
        public EmpireSquadron GuardianSquadron { get; }

        public EmpireArchFaction(EmpirePrism archLeader, EmpirePrism archGuardian)
        {
            this.LeadSquadron = new EmpireSquadron(archLeader, true);
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

    public class EmpirePrism : ParticlePrism
    {
        public EmpirePrism(IPrism prism) : base(prism, Particle.Delta) { }
        public EmpirePrism(PrismID pid) : base(pid) { }
        public EmpirePrism() : base(Particle.Delta) { }
    }

    public class EmpireHedron : ParticleHedron
    {
        public EmpireHedron(EmpirePrism leader, List<ParticlePrism> members) : base(
            leader,
            members
        )
        { }
        public EmpireHedron(EmpirePrism leader, bool isFull = true) : base(leader, isFull) { }
        public EmpireHedron(IHedron hedron) : base(hedron) { }
        public EmpireHedron(bool isFull = true) : base(Particle.Delta, isFull) { }
    }

    public class EmpireFamily : EmpireHedron, IFamily
    {
        public EmpireFamily(EmpirePrism parent1, EmpirePrism parent2, bool isFull = false)
        {
            InitFamily(parent1, parent2, isFull);
        }

        public EmpireFamily(IPrism parent1, EmpirePrism parent2, bool isFull = false)
        {
            InitFamily(new EmpirePrism(parent1), parent2, isFull);
        }

        public EmpireFamily(EmpirePrism parent1, IPrism parent2, bool isFull = false)
        {
            InitFamily(parent1, new EmpirePrism(parent2), isFull);
        }

        public EmpireFamily(IPrism parent1, IPrism parent2, List<IPrism> children)
        {
            InitFamily(
                new EmpirePrism(parent1),
                new EmpirePrism(parent2),
                false
            );
            this.Children = new();
            foreach (var prism in children)
            {
                this.Children.Add(new EmpirePrism(prism));
            }
        }

        public IPrism Father { get; private set; }

        public IPrism Mother { get; private set; }

        public List<IPrism> Children { get; }

        public QuantumName Name { get; }


        public void InitFamily(EmpirePrism parent1, EmpirePrism parent2, bool isFull)
        {
            EmpirePrism father;
            EmpirePrism mother;
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
                    var child = new EmpirePrism(
                        father.Breed(mother, false)
                    );
                    this.AddPrism(child, child.Pid);
                    this.Children.Add(child);
                }
            }
        }
    }

}
