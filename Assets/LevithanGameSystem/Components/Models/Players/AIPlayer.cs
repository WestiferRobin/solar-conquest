using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ParticleHedron: Hedron, IParticle
{
    public ParticleHedron(Particle pid): base() 
    { 
        this.ParticleID = pid;
    }

    public Particle ParticleID { get; }
}

public class AIPlayer : IPlayer
{
    public string FirstName { get => AvatarPrism.FirstName; }
    public string LastName { get => AvatarPrism.LastName; }

    public IPrism AvatarPrism { get => AvatarHedron.GetLeadPrism(); }
    public IHedron AvatarHedron { get; set; }

    public User UserOwner => throw new NotImplementedException();

    public AIPlayer(Particle firstName, Particle lastName)
    {
        var rand = new Random();

        var prismId = new PrismID(
            rand.Next() % 2 == 0 ? Gender.Male : Gender.Female,
            GetBirthSign(rand),
            Enum.GetName(typeof(Particle), firstName),
            Enum.GetName(typeof(Particle), lastName),
            FamilyName.Admin,
            firstName,
            lastName,
            CombatRank.Admin,
            GetCombatClass(rand)
        );
    }

    private BirthSign GetBirthSign(Random rand)
    {
        var signIndex = rand.Next(0, Enum.GetValues(typeof(BirthSign)).Length);

        var asdf = Enum.GetValues(typeof(BirthSign)).GetValue(signIndex);
        return (BirthSign)asdf;
    }

    private CombatClass GetCombatClass(Random rand)
    {
        var signIndex = rand.Next(0, Enum.GetValues(typeof(CombatClass)).Length);

        var asdf = Enum.GetValues(typeof(CombatClass)).GetValue(signIndex);
        return (CombatClass)asdf;
    }
}
