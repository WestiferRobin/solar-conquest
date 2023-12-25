using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AIPlayer : IPlayer
{
    public string FirstName { get => AvatarPrism.FirstName; }
    public string LastName { get => AvatarPrism.LastName; }

    public IPrism AvatarPrism { get => AvatarHedron.GetLeadPrism(); }
    public IHedron AvatarHedron { get; set; }

    public User UserOwner => throw new NotImplementedException();

    public AIPlayer(Particle pid, Particle hid)
    {
        var prismId = new PrismID(pid, hid);
        AvatarHedron = new ParticleHedron(
            new ParticlePrism(prismId)
        );
    }

    public AIPlayer()
    {
        var prismId = new ParticlePrismID();
        AvatarHedron = new ParticleHedron(
            new ParticlePrism(prismId)
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
