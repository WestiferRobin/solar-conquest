using System;
using System.Collections.Generic;
using SolarConquestGameModels;
using SoverignParticles;

public abstract class VehicleWeapon : IWeapon
{
    public VehicleWeapon()
    {

    }

    public List<int> WeaponScores => throw new NotImplementedException();

    public Particle ParticleID => throw new NotImplementedException();
}

