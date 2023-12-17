using SolarConquestGameModels;

public class UserPlayer : User, IPlayer
{
    public IPlayer Player { get; protected set; }

    public IPrism AvatarPrism { get; set; }
    public IHedron AvatarHedron { get; set; }
    public new string FirstName { get => AvatarPrism.FirstName; }
    public new string LastName { get => AvatarPrism.LastName; }

    public UserPlayer(IPlayer player) : base(player.FirstName, player.LastName)
    {
        this.Player = player;
    }

    protected UserPlayer(IPrism prism): base(prism.FirstName, prism.LastName)
    {
        this.AvatarPrism = prism;
        this.AvatarHedron = new SinglePrismHedron(this.AvatarPrism as Prism);
    }
}

public class PrismPlayer: UserPlayer, IPlayer
{
    public PrismPlayer(PrismID prismID): base(new Prism(prismID))
    {
        base.Player = this;
    }

    public PrismPlayer(IPrism prism): base(prism)
    {
        base.Player = this;
    }
}

