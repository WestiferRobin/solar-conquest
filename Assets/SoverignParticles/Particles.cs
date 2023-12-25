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

        public static List<Particle> GetList()
        {
            var particles = Enum.GetValues(typeof(Particle)).Cast<Particle>().ToList();
            return particles;
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
