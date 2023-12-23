using SolarConquestGameModels;
using SoverignParticles;

public class UserPrism: Prism
{
    public User User { get; }

    public UserPrism(User user, IPrism prism): base(prism)
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
    public PrismPlayer(PrismID prismID): base(new Prism(prismID))
    {
    }

    public PrismPlayer(IPrism prism): base(prism)
    {
    }
}

