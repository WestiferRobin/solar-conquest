using System;
using SolarConquestGameModels;
using SoverignParticles;

public class ParticlePlayer : IParticle, IPlayer
{
    private ParticlePrism PlayerPrism { get; set; }
    public IPrism AvatarPrism { get => PlayerPrism; }

    private ParticleHedron PlayerHedron { get; set; }
    public IHedron AvatarHedron { get => PlayerHedron; }

    public string FirstName { get => PlayerPrism.FirstName; }
    public string LastName { get => PlayerPrism.LastName; }

    public Particle Pid => AvatarPrism.Pid;
    public Particle Hid => AvatarPrism.Hid;
    public Particle ParticleID => Pid;

    public ParticlePlayer(Particle pid)
    {
        this.PlayerPrism = new ParticlePrism(pid);
        this.PlayerHedron = new ParticleHedron(this.PlayerPrism, isFull: true);
    }

    public ParticlePlayer(PrismID prismId)
    {
        this.PlayerPrism = new ParticlePrism(prismId);
        this.PlayerHedron = new ParticleHedron(this.PlayerPrism, isFull: true);
    }

    protected ParticlePlayer(IPrism prism, Particle pid)
    {
        this.PlayerPrism = new ParticlePrism(prism, pid);
        this.PlayerHedron = new ParticleHedron(this.PlayerPrism, isFull: true);
    }
}


