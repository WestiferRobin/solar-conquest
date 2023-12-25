using System;

public class ParticleSystem: ISystem
{
    public User Owner { get; }

    public ParticleSystem(User owner)
	{
		this.Owner = owner;
	}
}

