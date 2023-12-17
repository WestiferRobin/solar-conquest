using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SolarConquestGameModels
{
    public abstract class Planet
    {

        public static int MaxSides = 6;

        public string Name { get; protected set; }
        public List<PlanetSide> Sides { get; protected set; }
        public List<Moon> Moons { get; protected set; }

        protected Planet(Planet moon)
        {
            this.Name = moon.Name;
            this.Sides = moon.Sides;
            this.Moons = moon.Moons;
        }

        public Planet(string name) 
        { 
            InitPlanet(name, moonSize: 0);
        }

        public Planet(string name, int moonSize)
        {
            InitPlanet(name, moonSize);
        }

        public Planet(string name, List<Moon> moons) 
        {
            InitPlanet(name, moons);
        }

        private void InitPlanet(string name, int moonSize)
        {
            var moons = new List<Moon>();
            for (int moonIndex = 0; moonIndex < moonSize; moonIndex++)
            {
                this.Moons.Add(new DeadMoon($"{name}'s Dead Moon #{moonIndex += 1}"));
            }
            InitPlanet(name, moons);
        }

        private void InitPlanet(string name, List<Moon> moons)
        {
            this.Name = name;

            this.Moons = moons;

            this.InitSides();
        }

        private void InitSides()
        {
            this.Sides = new List<PlanetSide>();
            for (int planetIndex = 0; planetIndex < MaxSides; planetIndex++)
            {
                this.Sides.Add(new PlanetSide(planetIndex));
            }
        }

        public void Update()
        {
            foreach (var side in Sides)
            {
                side.Update();
            }

            foreach (var moon in Moons)
            {
                moon.Update();
            }
        }
    }
}
