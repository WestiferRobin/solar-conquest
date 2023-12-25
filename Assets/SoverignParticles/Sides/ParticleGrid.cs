using System;
using SoverignParticles;

public class ParticleGrid: SideGrid, IParticle
{
	public Particle ParticleID { get; }
	public ParticleGrid(Particle pid): base(pid)
	{
		this.ParticleID = pid;
	}
}

