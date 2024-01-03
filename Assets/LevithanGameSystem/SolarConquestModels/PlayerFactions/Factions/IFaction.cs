using SoverignParticles;

namespace SolarConquestGameModels
{
    public interface IFaction
    {
        bool IsOperational();
        void ApplyToBoard(GalaxyBoard galaxy, int index);
    }

    public interface IAdminFaction: IFaction
    {
        IPrism Admin { get; }
        IPrism AdminGuardian { get; }

        IPrism GetArchLeader(Particle pid);
        IPrism GetArchGuardian(Particle pid);

        IArchFaction AdminFaction => GetArchFaction(Admin.Hid);
        IArchFaction GetArchFaction(Particle pid);

        void Update();

        // Royale Family
        // Admin Family: Admin Atlantian Family
        // Arch Families: example is Federation
        //  - Arch Terrian Family
        //  - Arch Martian Family
        //  - Arch Venatoan Family
        //  - Arch Nepatoan Family

        // Guardian Order => Atlantian Order
        //      4 schools of magi and 1 of councile with 1 master
        //      1 master is Admin Guardian: Atlantian Guardian

        // Guardian Armada => Dreadnought over Titan
        // Admin Armada => AdminEliteFleet over Earth Citadel

        // Arch Faction => All Arch Families
        // Admin Planets => All Faction Planets
        // Admin Moons => All Faction Moons
        // Admin Colonies => All Faction Colonies
        // Admin Population => All Faction Hedron and types
    }

    public interface IArchFaction: IFaction
    {
        IPrism Leader { get; }
        IPrism Guardian { get; }

        void Update();



        // Royale Family
        // Magi Armada
        // Royale Armada
        // Faction Planets
        // Faction Moons
    }
}