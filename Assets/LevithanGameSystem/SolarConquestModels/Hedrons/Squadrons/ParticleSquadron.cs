using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public class ParticleSquadron: ParticleHedron, ISquadron
    {
        public ParticleSquadron(ParticlePrism leader, bool isFull): base(leader, isFull) { }

        public ParticleSquadron(IHedron hedron, Particle pid) : base(hedron, pid)
        { 
            
        }

        public ParticleSquadron(): base()
        {

        }

        public void Battle(ISquadron enemy)
        {
            while (this.IsAlive() && enemy.IsAlive())
            {

            }
        }

        public void Bond()
        {
            var visited = new Dictionary<Particle, List<Particle>>();
            foreach (var pid in this.Registry.Keys)
            {
                visited.Add(pid, new());
            }
            
            foreach (var pid in this.Registry.Keys)
            {
                foreach (var tid in this.Registry.Keys)
                {
                    if (pid == tid) continue;
                    if (!visited[pid].Contains(tid))
                    {
                        visited[pid].Add(tid);
                        var source = this.Registry[pid];
                        var target = this.Registry[tid];
                        source.Socialize(target);
                    }
                }
            }
        }
    }
}
