using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestGameModels
{
    public abstract class VehicleArmor: IArmor
    {
        public VehicleArmor()
        {

        }
    }

    public interface IArmor
    {

    }

    public abstract class VehicleLifeSupport: ILifeSupport
    {
        public VehicleLifeSupport()
        {

        }
    }

    public interface ILifeSupport
    {
    }

    public interface IVehicleEngine
    {

    }

    public abstract class VehicleEngine: IVehicleEngine
    {
        public VehicleEngine()
        {

        }
    }

    public interface IShields
    {

    }

    public abstract class VehicleShields: IShields
    {
        public VehicleShields()
        {

        }
    }

    public interface IVehicle
    {
        string Name { get; }

        IPrism Opperator { get; }

        VehicleArmor Armor { get; }

        VehicleShields Shields { get; }

        VehicleLifeSupport LifeSupport { get; }

        VehicleEngine Engine { get; }

        VehicleWeapon PrimaryWeapon { get; }

        VehicleWeapon SecondaryWeapon { get; }
    }
}