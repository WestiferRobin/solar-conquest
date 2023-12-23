using Assets.SoverignParticles.Components;
using SolarConquestGameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IPlayer
{
    public string FirstName { get; }
    public string LastName { get; }

    public IHedron AvatarHedron { get; }

    public IPrism AvatarPrism { get; }

    string Name => $"{FirstName} {LastName}";
}
