using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public interface IVector
    {
        int CalculateMagnitude(int x0, int y0, int z0);
        int CalculateMagnitude(int x0, int y0);
        int CalculateMagnitude();

        int Magnitude { get; }
    }

    public class UnityVector: IVector
    {
        public int X { get; }
        public int Y { get; }
        public int Z { get; }

        public int Magnitude => CalculateMagnitude();


        private int powToTwo(int x1, int x2 = 0)
        {
            int term = (int)Math.Pow(x1 - x2, 2);
            return term;
        }

        public int CalculateMagnitude(int x0, int y0, int z0)
        {
            int magnitude = 0;

            int x = powToTwo(this.X, x0);
            int y = powToTwo(this.Y, y0);
            int z = powToTwo(this.Z, z0);

            magnitude += x + y + z;

            return (int) Math.Sqrt(magnitude);
        }

        public int CalculateMagnitude(int x0, int y0)
        {
            return CalculateMagnitude(x0, y0, 0);
        }

        public int CalculateMagnitude()
        {
            return CalculateMagnitude(0, 0, 0);
        }

        public int CalculateMagnitude(UnityVector position)
        {
            return CalculateMagnitude(
                position.X,
                position.Y,
                position.Z
            );
        }

        public UnityVector(int x, int y, int z = 0)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public UnityVector()
        {
            this.X = 0;
            this.Y = 0;
            this.Z = 0;
        }

    }

    public interface IPrism
    {
        PrismID ID { get; }
        string FirstName { get; }
        string LastName { get; }

        UnityVector Position { get; }
        PrismBody Body { get; }

        Particle Pid { get; }
        Particle Hid { get; set; }

        FamilyName FactionName { get; }

        Dictionary<Particle, IHedron> HedronNetwork { get; }
        Dictionary<PrismSkillID, PrismSkill> Skills { get; }

        void InitPrism(PrismID id);

        bool IsAlive();

        bool InRange(IPrism target);
        bool InRange(UnityVector vector);
        void Attack(IPrism target);
        void Defend(int attackScore);
        bool Dodge();

        IPrism Breed(IPrism partner, bool isRandom);
        bool Knows(IPrism target);
        void Socialize(IPrism target);
        void Move(UnityVector position);

        void Update();
    }
}
