using SolarConquestGameModels;
using SoverignParticles;

public class ParticleGame : ParticleApp, IGame
{

    public GamePlayer MainPlayer { get; }

    public GamePlayer OpponentPlayer { get; }

    public IBoard Board { get; }

    public ParticleGame(GamePlayer main, GamePlayer opponent, IBoard board, Particle particleID): base(particleID)
    {
        this.MainPlayer = main;
        this.OpponentPlayer = opponent;
        this.Board = board;
    }

    public override bool IsRunning()
    {
        return MainPlayer.AvatarHedron.IsAlive() &&
            OpponentPlayer.AvatarHedron.IsAlive() &&
            base.IsRunning();
    }

    public override void Update()
    {
        this.Board.Update();

        this.MainPlayer.Update();

        this.Board.Update();

        this.OpponentPlayer.Update();

        this.Board.Update();
    }
}
