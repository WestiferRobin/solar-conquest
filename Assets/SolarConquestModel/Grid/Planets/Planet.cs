using Assets.SolarConquestModel.Grid;
using SolarConquest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class Planet : IGridUpdater
    {
        public static int MaxSides = 6;

        public string Name { get; }
        public List<IFleet> Orbit { get; }
        public List<PlanetSide> PlanetSides { get; protected set; }
        public List<Moon> Moons { get; protected set; }

        public Planet(string name, int moonSize=1) {
            this.Name = name;

            this.Orbit = new List<IFleet>();

            this.Moons = new List<Moon>();
            for (int moonIndex = 0; moonIndex < moonSize; moonIndex++)
            {
                this.Moons.Add(new Moon(moonIndex));
            }

            this.PlanetSides = new List<PlanetSide>();
            for (int planetIndex = 0;  planetIndex < MaxSides; planetIndex++)
            {
                this.PlanetSides.Add(new PlanetSide(planetIndex));
            }
        }

        public void Update()
        {
            foreach (var side in this.PlanetSides)
            {
                side.Update();
            }
            foreach (var fleet in this.Orbit)
            {
                fleet.Update();
            }
            foreach (var moon in this.Moons)
            {
                moon.Update();
            }
        }
    }

    public class DeadPlanet : Planet
    {
        public DeadPlanet(string name, int moonSize=1) : base(name, moonSize)
        {
            var updatedSides = new List<PlanetSide>();
            foreach (var side in PlanetSides)
            {
                var planetSide = new DeadPlanetSide(side);
                updatedSides.Add(planetSide);
            }
            this.PlanetSides = updatedSides;

            var updatedMoons = new List<Moon>();
            foreach (var moon in this.Moons)
            {
                var updatedMoon = new DeadMoon(moon);
                updatedMoons.Add(updatedMoon);
            }
            this.Moons = updatedMoons;
        }
    }

    public class LifePlanet : DeadPlanet
    {
        public LifePlanet(string name, int moonSize = 1) : base(name, moonSize)
        {
            var updatedSides = new List<PlanetSide>();
            foreach (var side in PlanetSides)
            {
                var planetSide = new LifePlanetSide(side);
                updatedSides.Add(planetSide);
            }
            this.PlanetSides = updatedSides;
        }
    }


    public class GasPlanet: Planet
    {
        public GasPlanet(string name, int lifeMoonSize=2, int deadMoonSize=1) : base(name, lifeMoonSize + deadMoonSize)
        {
            var updatedSides = new List<PlanetSide>();
            foreach (var side in PlanetSides)
            {
                var planetSide = new GasPlanetSide(side);
                updatedSides.Add(planetSide);
            }
            this.PlanetSides = updatedSides;

            var updatedMoons = new List<Moon>();
            foreach (var moon in this.Moons)
            {
                var updatedMoon = new LifeMoon(moon);
                updatedMoons.Add(updatedMoon);
            }
            this.Moons = updatedMoons;
        }
    }
}
