// See https://aka.ms/new-console-template for more information
using SolarConquest;

namespace SolarPlayground
{
    public static class Playground
    {
        public static void Main(string[] args)
        {
            var game = new SolarConquestWesGame();
            game.Start();
        }
    }
}
