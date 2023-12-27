using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoverignParticles
{
    public enum Particle
    {
        Delta = 0xFFF,
        Theta = 0x0FF,
        Phi = 0xF0F,
        Lambda = 0xFF0,

        Sigma = 0xF80,
        Epsilon = 0xF08,
        Mu = 0x888,
        Psi = 0x80F,

        Alpha = 0xF00,
        Gamma = 0x0F0,
        Beta = 0x00F,
        Omega = 0x000
    }

    public interface IParticle
    {
        public static Particle GetRandom()
        {
            var rand = new Random();
            var particles = GetList();
            int index = rand.Next(0, particles.Count);
            return particles[index];
        }

        public static Dictionary<Particle, T> GetDictionary<T>(Stack<T> stack)
        {
            var dict = new Dictionary<Particle, T>();
            if (stack.Count <= 0) return dict;

            var particles = GetList();
            foreach (var particle in particles)
            {
                if (stack.Count <= 0) break;
                var item = stack.Pop();
                dict.Add(particle, item);
            }

            return dict;
        }

        public static Dictionary<Particle, T> GetDictionary<T>(Queue<T> queue)
        {
            var itemStack = new Stack<T>();

            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                itemStack.Push(item);
            }

            return GetDictionary(itemStack);
        }

        public static Dictionary<Particle, T> GetDictionary<T>(List<T> list)
        {
            var itemStack = new Stack<T>();
            foreach (var item in list) itemStack.Push(item);
            return GetDictionary(itemStack);
        }

        public static Stack<Particle> GetStack(bool isRandom = true)
        {
            var stack = new Stack<Particle>();
            var list = GetList(isRandom);
            foreach (var particle in list)
            {
                stack.Push(particle);
            }

            return stack;
        }

        public static Queue<Particle> GetQueue(bool isRandom = true)
        {
            var queue = new Queue<Particle>();
            var list = GetList(isRandom);
            foreach (var particle in list)
            {
                queue.Enqueue(particle);
            }
            return queue;
        }

        public static List<Particle> GetList(bool isRandom = true)
        {
            var particles = Enum.GetValues(typeof(Particle))
                                .Cast<Particle>().ToList();

            if (!isRandom) return particles;

            var rand = new Random();
            var list = new List<Particle>();

            while (particles.Count > 0)
            {
                int index = rand.Next(0, particles.Count);
                var particle = particles[index];
                list.Add(particle);
            }

            return list;
        }

        public static Particle FindParticle(int particleIndex)
        {
            foreach (var particle in GetList())
            {
                if ((int)particle == particleIndex) return particle;
            }
            throw new Exception($"PARTICLE NOT FOUND FOR INDEX {particleIndex}");
        }

        Particle ParticleID { get; }
        int ParticleIndex { get => (int) ParticleID;  }
    }
}
