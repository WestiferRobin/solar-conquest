using System;
using System.Collections.Generic;
using SoverignParticles;

namespace SolarConquestGameModels
{
    public abstract class ParticleWeapon: IWeapon
    {
        public Particle ParticleID { get; }
        public List<int> WeaponScores { get; }

        public ParticleWeapon(Particle pid, List<int> weaponScores)
        {
            this.ParticleID = pid;
            this.WeaponScores = weaponScores;
        }
    }

    public class ParticleMeleeWeapon : ParticleWeapon, IMeleeWeapon
    {
        private int MaxCombo { get; }
        private int CurrentCombo { get; set; }

        public ParticleMeleeWeapon(Particle pid, int maxCombo, List<int> weaponScore): base(
            pid,
            weaponScore
        )
        {
            this.MaxCombo = maxCombo;
            this.CurrentCombo = maxCombo;
        }

        public bool CanSlash()
        {
            return this.CurrentCombo > 0;
        }

        public int Slash()
        {
            if (!CanSlash())
            {
                this.CurrentCombo = this.MaxCombo;
                return 0;
            }

            var rand = new Random();
            int index = rand.Next(0, WeaponScores.Count);
            return WeaponScores[index];
        }
    }


    public class ParticleRangeWeapon : ParticleWeapon, IRangeWeapon
    {
        private int MaxAmmo { get; }
        private int CurrentAmmo { get; set; }

        public ParticleRangeWeapon(Particle pid, int maxAmmo, List<int> weaponScores): base(pid, weaponScores)
        {
            this.MaxAmmo = maxAmmo;
            this.CurrentAmmo = maxAmmo;
        }

        public int Fire()
        {
            if (!IsEmpty()) return 0;
            var rand = new Random();
            int index = rand.Next(0, WeaponScores.Count);
            return WeaponScores[index];
        }

        public bool IsEmpty()
        {
            return CurrentAmmo <= 0;
        }

        public void Reload()
        {
            this.CurrentAmmo = this.MaxAmmo;
        }
    }
}
