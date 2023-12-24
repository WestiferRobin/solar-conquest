using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ParticleGameSystem: GameSystem, IParticle
{
    public Particle ParticleID { get; }

    public ParticleGameSystem(Particle pid, UserPlayer owner, GameEngine engine): base(owner, engine)
    {
        this.ParticleID = pid;
    }

    public ParticleGameSystem(Particle pid, UserPlayer owner): base(owner, new GameEngine(pid))
    {
        this.ParticleID = pid;
    }
}


public class LevithanGameSystem: ParticleGameSystem
{


    public LevithanGameSystem() : base(
        Particle.Omega,
        new WesPlayer(),
        new SoverignEngine()
    )
    {
        this.LoadGame(
            new SolarConquestGame(
                this.OwnerPlayer,
                new EvilWesPlayer()
            )
        );
    }
}
