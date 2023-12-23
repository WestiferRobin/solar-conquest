using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ParticleComponent : IComponent, IParticle
{
    public Particle ParticleID { get; }

    public IComponentModel ComponentModel => throw new NotImplementedException();

    public IComponentView ComponentView => throw new NotImplementedException();

    public IComponentController ComponentController => throw new NotImplementedException();

    public ParticleComponent(Particle particleID)
    {
        ParticleID = particleID;
    }   
}

public class ParticleGameComponent : ParticleComponent, IGame
{
    public ParticleGame Game { get; }

    public GameEngine Engine => throw new NotImplementedException();

    public GamePlayer MainPlayer => throw new NotImplementedException();

    public GamePlayer OpponentPlayer => throw new NotImplementedException();

    public GameBoard Board => throw new NotImplementedException();

    public ViewModel ModelView => throw new NotImplementedException();

    public ModelController ModelController => throw new NotImplementedException();

    public ParticleGameComponent(IGame game, Particle pid): base(pid) 
    {
        this.Game = new ParticleGame(game.MainPlayer, game.OpponentPlayer, game.Board, pid);
    }

    public ParticleGameComponent(ParticleGame game): base(game.ParticleID)
    {
        this.Game = game;
    }

    public void Update()
    {
        throw new NotImplementedException();
    }

    public bool IsRunning()
    {
        throw new NotImplementedException();
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }

    public void Tick()
    {
        throw new NotImplementedException();
    }
}
