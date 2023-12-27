using SolarConquestGameModels;
using SoverignParticles;

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
