using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GameEngine : ParticleEngine
{
    public GameEngine(Particle pid) : base(pid) { }

    public IGame Game => this.App as IGame;

    public IGame EjectGame()
    {
        return base.Eject() as IGame;
    }
}
