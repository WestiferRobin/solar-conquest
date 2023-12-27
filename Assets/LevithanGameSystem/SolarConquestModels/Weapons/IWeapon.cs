using System;
using SoverignParticles;
using System.Collections.Generic;

namespace SolarConquestGameModels
{
    /*
        Weapons:

            PrismWeapons have Melee or Ranged
    */
    public interface IWeapon : IParticle
    {
        List<int> WeaponScores { get; }
    }

    public interface IMeleeWeapon : IWeapon
    {
        int Slash();
        bool CanSlash();
    }

    public interface IRangeWeapon : IWeapon
    {
        int Fire();
        bool IsEmpty();
        void Reload();
    }
}
