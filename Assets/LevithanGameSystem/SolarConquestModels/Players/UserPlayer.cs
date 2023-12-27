using SolarConquestGameModels;
using SoverignParticles;

// Move to Prisms
public class UserPrism: ParticlePrism
{
    public User User { get; }

    public UserPrism(User user, IPrism prism, Particle pid): base(prism, pid)
    {
        this.User = user;
    }

    public UserPrism(User user, PrismID pid): base(pid)
    {
        this.User = user;
    }
}

public class UserPlayer : ParticlePlayer
{
    public User User { get; }
    public string Name => User.Name;

    public UserPlayer(UserPrism user): base(user, user.ID.Pid)
    {
        this.User = user.User;
    }

    public UserPlayer(User user, PrismID id): base(id)
    {
        this.User = user;
    }
}

// Move to Players
public class PrismPlayer: ParticlePlayer
{
    public PrismPlayer(PrismID prismID): base(new ParticlePrism(prismID), prismID.Pid)
    {
    }

    public PrismPlayer(IPrism prism): base(prism, prism.Pid)
    {
    }
}

