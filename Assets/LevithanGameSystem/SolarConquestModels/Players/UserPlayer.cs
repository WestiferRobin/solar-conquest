using SolarConquestGameModels;
using SoverignParticles;

public class UserPrism: ParticlePrism
{
    public User User { get; }

    public UserPrism(User user, IPrism prism, Particle pid): base(prism, pid)
    {
        this.User = user;
    }
}

public class UserPlayer : ParticlePlayer
{
    public User User { get; }
    public string Name => User.Name;

    public UserPlayer(User user): base(
        IParticle.GetRandom()
    )
    {
        this.User = user;
    }
}

public class PrismPlayer: ParticlePlayer
{
    public PrismPlayer(PrismID prismID): base(new ParticlePrism(prismID), prismID.Pid)
    {
    }

    public PrismPlayer(IPrism prism): base(prism, prism.Pid)
    {
    }
}

