// See https://aka.ms/new-console-template for more information
using SolarConquest;

namespace SolarConquestPlayground
{
    public class Playground
    {
        public static void Main(string[] args)
        {
            // TODO: Start doing Unit Tests after GalaxyGrid is created
            // IDEA IS THAT TEXT GAME => UNITY GAME WITH ENGINE AS THE ADAPTER!
            var myGame = new SolarConquestWesGame();
            var galaxyGrid = myGame.GameBoard;
            myGame.Start();
        }
    }
}