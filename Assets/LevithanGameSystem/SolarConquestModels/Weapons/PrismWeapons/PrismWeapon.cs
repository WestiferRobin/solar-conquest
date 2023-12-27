using System;
using System.Collections.Generic;
using SoverignParticles;

namespace SolarConquestGameModels
{
    /*
	- CombatType => [PrimaryWeapon, SecondaryWeapon, Item:[PackItem, GrenadeItem]] => 4 Slots => PrismSlotConfiguration
        - Number on side includes percents they appear per faction at birth for Guardian Gene per Power with 1 Family
        25 - Marine => LaserRifle, Pistol, MedPack:AmmoPack:RepairPack, FragGrenade
            - Strong Against: Specialist, Officer
            - Weak Against: Commando, Officer, Specialist
        20 - Ranger => CombatLaserGun, PlasmaSaber, StimPack:[Attack, Defense], ProtonGrenade
            - Strong Against: Specialist, Officer, Marine
            - Weak Against: Commando, Officer, Specialist
        18 - Specialist => PlasmaRifle, Revolver, EmergencyKit => [2 MedPacks, 1 Repair], StunGrenade:[NeutronGrenade, ElectronGrenade]
            - Strong Against: Commando, Officer, Marine
            - Weak Against: Ranger, Marine
        15 - Commando => MachineLaserGun, Magnum, AttackStimPack, GrenadeLauncher:[3 ProtonGrenades]
            - Strong Against: Marine, Ranger, Officer, Guardian
            - Weak Against: Specialist, Officer
        12 - Officer => SniperPlasmaRifle, SilencerPistol, DefenseStimPack, ElectronGrenade
            - Strong Against: Marine, Ranger, Commando, Guardian
            - Weak Against: Specialist, Commando
        10 - Guardian => GuardianLaserRifle, LaserSaber, 2 Powers:[Quazar, Photon, Electron, Neutron, Proton]
            - Strong Against: Guardian, Marine, Ranger, Specialist
            - Weak Against: Guardian, Commando, Officer

    RangeWeapons:
        Marine: BattleRifle, Pistol
        Ranger: CombatGun, LightMachineGun
        Specialist: AssultRifle, Revolver
        Commando: MachineGun, Magnum
        Officer: SniperRifle, Sword
        Magi: Magi Powers, Staff or Sword


	*/
    public abstract class PrismWeapon: ParticleWeapon
	{
		public PrismWeapon(Particle pid, List<int> weaponScores): base(pid, weaponScores)
		{
		}
	}

	public class PrismMeleeWeapon : PrismWeapon, IMeleeWeapon
	{
		private ParticleMeleeWeapon Weapon { get; }

		public PrismMeleeWeapon(Particle pid, int maxCombo, List<int> weaponScores): base(pid, weaponScores)
		{
			Weapon = new ParticleMeleeWeapon(pid, maxCombo, weaponScores);
		}

        public int Slash()
        {
			return Weapon.Slash();
        }

        public bool CanSlash()
        {
			return Weapon.CanSlash();
        }
    }

	public class PrismRangeWeapon : PrismWeapon, IRangeWeapon
	{
		private ParticleRangeWeapon Weapon { get; }

		public PrismRangeWeapon(Particle pid, int maxAmmo, List<int> weaponScores): base(pid, weaponScores)
		{
			Weapon = new ParticleRangeWeapon(pid, maxAmmo, weaponScores);
		}

        public int Fire()
        {
			return Weapon.Fire();
        }

        public bool IsEmpty()
        {
			return Weapon.IsEmpty();
        }

        public void Reload()
        {
			Weapon.Reload();
        }
    }
}
