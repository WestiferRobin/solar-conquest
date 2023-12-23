using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SoverignEngineComponent: EngineComponent
{
    public SoverignEngineComponent(): base(new SoverignEngine()) { 
    }
}

public class SoverignEngine: GameEngine
{
    public SoverignEngine(): base(Particle.Omega) { }
}
