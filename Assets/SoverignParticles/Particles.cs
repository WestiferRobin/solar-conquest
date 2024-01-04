using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoverignParticles
{
    /*
    Particle Vertex 
        Note: Dimension Notation is Particle:D:?

    Delta-D:0 Particle:Vertex:Point
        - Reality Density: % as Z when 0 <= Z <= 1
            - e*iZ = cosX + i*sinY
            - when X and Y has valid solutions for e*iZ
        - VertexPoint Types
            - Particle <p>
            - Numeric <x>
            - Void <0>
            - Tile <a, g, b>
    Lambda-D:1 Vector:VertexEdge:Length
        - LineAxisGrid => VertexPointGrid
        - VertexEdge:
            - SourcePoint: VertexPoint
            - TargetPoint: VertexPoint
    Alpha-D:2 Square:VertexFace:Area
        - AreaAxisGrid => LineGrid
        - VertexArea:
            - LineLength:VertexEdge
            - LineWidth:VertexEdge
    Gamma-D:3 Cube:VertexPolygon:Volume
        - VolumeAxisGrid => AreaAxisGrid
        - VertexVolume
            - SourceArea: VertexArea
                - Height:VertexEdge
            - TargetArea: VertexArea
                - Length:VertexEdge
                - Width:VertexEdge
    Beta-D:4 HyperCube:HyperPolygon:HyperVolume
        - HyperAxisGrid => Volumes, Areas, Lines, Verticies
        - HyperVolume:
            - VolumeSource: VertexPolygon
            - VolumeTarget: VertexPolygon
    Mu-D:5 SovereignMesh:SovereignPolygon:SovereignVolume
    Epsilon-D:6 ParticleMesh:VertexPolygon:
    Sigma-D:7
    Phi-D:8
    Theta-D:9 
    Psi-D:10
    Omega-D:11 Circle on ComplexPlane of D:0 transparency density



    */

    // Order Particle density vertex
    public enum Particle
    {
        Delta = 0xFFF,

        Lambda = 0xFF0,
        Sigma = 0xF80,
        Epsilon = 0xF08,
        Alpha = 0xF00,
        Phi = 0xF0F,

        Mu = 0x888,

        Psi = 0x80F,
        Theta = 0x0FF,
        Gamma = 0x0F0,
        Beta = 0x00F,

        Omega = 0x000
        /*
        Delta = 0xFFF, ASDF
        Theta = 0x0FF, ASDF
        Phi = 0xF0F, ASDF
        Lambda = 0xFF0, ASDF

        Sigma = 0xF80, ASDF
        Epsilon = 0xF08, ASDF
        Mu = 0x888, ASDF
        Psi = 0x80F, ASDF

        Alpha = 0xF00, ASDF
        Gamma = 0x0F0, ASDF
        Beta = 0x00F, ASDF
        Omega = 0x000 ASDF
        */
    }

    public interface IParticle
    {
        public static List<Particle> GetRandomList(List<Particle> list)
        {
            var randomList = new List<Particle>();
            var compareList = GetList(true);

            foreach (var particle in compareList)
            {
                if (list.Contains(particle))
                {
                    randomList.Add(particle);
                }
            }

            return randomList;
        }

        public static List<Particle> GetRandomList()
        {
            var list = GetList();
            return GetRandomList(list);
        }

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

            while (list.Count < particles.Count)
            {
                int index = rand.Next(0, particles.Count);
                var particle = particles[index];
                while (list.Contains(particle))
                {
                    index = rand.Next(0, particles.Count);
                    particle = particles[index];
                }
                //if (list.Contains(particle)) continue;
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
