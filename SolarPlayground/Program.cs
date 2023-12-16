// See https://aka.ms/new-console-template for more information
using SolarConquest;

namespace SolarPlayground
{
    public static class Playground
    {
        public static void Main(string[] args)
        {
            SolarConquestGame solarConquest = new SolarConquestWesGame();

            IGame game = solarConquest;

            //ParticleApp particleApp = (ParticleApp)game;
            //// IF THIS FAR THEN THE API WORKS FOR PARTICLE APPS
            //ParticleEngine particleEngine = new ParticleEngine();

            // Engine needs to update the App the engine is connected to
            // Engine is attached to a Ship to Move
            // so a ParticleEngine is attached to a ParticleShip to Move
            // thus ParticleGame on a ParticleGameEngine for 

        }
    }
}
