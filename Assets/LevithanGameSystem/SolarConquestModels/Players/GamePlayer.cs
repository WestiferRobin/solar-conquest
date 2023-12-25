using SolarConquestGameModels;
using SoverignParticles;

public class ParticlePlayer : IParticle, IPlayer
{
    public IPrism AvatarPrism { get; set; }
    public IHedron AvatarHedron { get; set; }
    public string FirstName { get => AvatarPrism.FirstName; }
    public string LastName { get => AvatarPrism.LastName; }
    public Particle ParticleID { get; }

    public ParticlePlayer(Particle pid)
    {
        this.AvatarPrism = new ParticlePrism(pid);
        this.AvatarHedron = new ParticleHedron(pid, isFull: true);
        this.AvatarHedron.Registry[pid] = this.AvatarPrism;

        this.ParticleID = pid;
    }

    public ParticlePlayer(PrismID prismId)
    {
        this.AvatarPrism = new ParticlePrism(prismId);
        this.AvatarHedron = new ParticleHedron(prismId.Pid, isFull: true);
        this.AvatarHedron.Registry[prismId.Pid] = this.AvatarPrism;

        this.ParticleID = prismId.Pid;
    }

    protected ParticlePlayer(IPrism prism, Particle pid)
    {
        this.AvatarPrism = new ParticlePrism(prism, pid);
        this.AvatarHedron = new ParticleHedron(pid, isFull: true);
        this.AvatarHedron.Registry[pid] = this.AvatarPrism;

        this.ParticleID = pid;
    }
}

public class GamePlayer : ParticlePlayer
{
    public GamePlayer(Particle pid) : base(pid)
    {
    }

    public GamePlayer(ParticlePrism prism) : base(prism, prism.Pid)
    {

    }

    public void Update()
    {
        base.AvatarHedron.Update();
    }
}
