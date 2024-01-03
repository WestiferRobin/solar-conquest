using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using SoverignParticles;

namespace SolarConquestGameModels
{
    public abstract class Planet: IParticle
    {
        public Particle ParticleID { get; private set; }
        public static int MaxSides = 6;

        public string Name { get; protected set; }
        public List<PlanetSide> PlanetSides { get; protected set; }
        public List<ISide> AllSides => GetAllSides();
        public List<Moon> Moons { get; protected set; }

        private List<ISide> GetAllSides()
        {
            var sides = new List<ISide>();

            foreach (var planetSide in PlanetSides)
            {
                sides.Add(planetSide);
            }

            foreach (var moon in Moons)
            {
                foreach (var moonSide in moon.Sides)
                {
                    sides.Add(moonSide);
                }
            }

            return sides;
        }

        protected Planet(Particle particle, Moon moon)
        {
            this.ParticleID = particle;
            this.Name = moon.Name;
            this.PlanetSides = new();
            this.Moons = new();
        }

        public Planet(Particle particle, string name) 
        { 
            InitPlanet(particle, name, moonSize: 0);
        }

        public Planet(Particle particle, string name, int moonSize)
        {
            InitPlanet(particle, name, moonSize);
        }

        public Planet(Particle particle, string name, List<Moon> moons) 
        {
            InitPlanet(particle, name, moons);
        }

        private void InitPlanet(Particle particle, string name, int moonSize)
        {
            var moons = new List<Moon>();
            for (int moonIndex = 0; moonIndex < moonSize; moonIndex++)
            {
                var deadMoon = new DeadMoon($"{name}'s Dead Moon #{moonIndex += 1}");
                moons.Add(deadMoon);
            }
            InitPlanet(particle, name, moons);
        }
         
        private void InitPlanet(Particle particle, string name, List<Moon> moons)
        {
            this.ParticleID = particle;

            this.Name = name;

            this.Moons = moons;

            this.InitSides();
        }

        private void InitSides()
        {
            this.PlanetSides = new List<PlanetSide>();
            for (int planetIndex = 0; planetIndex < MaxSides; planetIndex++)
            {
                this.PlanetSides.Add(new PlanetSide(planetIndex));
            }
        }

        public void Update()
        {
            foreach (var side in PlanetSides)
            {
                side.Update();
            }

            foreach (var moon in Moons)
            {
                moon.Update();
            }
        }

        public abstract void Build();
    }
}
