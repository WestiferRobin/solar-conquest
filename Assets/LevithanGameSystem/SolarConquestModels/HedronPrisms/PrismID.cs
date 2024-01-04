using SolarConquestGameModels;
using SoverignParticles;
using System;

public class PrismID
{
    public Particle Pid { get; set; }
    public Particle Hid { get; set; }

    public string FirstName { get => this.NameID.FirstName; }
    public string LastName { get => this.NameID.LastName; }
    public string Name { get => $"{FirstName}, {LastName}"; }

    public PrismNameID NameID { get; set; }
    public RaceID RaceID { get; set; }
    public Particle FactionID { get; set; }

    public QuantumName FamilyID { get; set; }
    public Gender GenderID { get; set; }
    public ZodiacSign BirthID { get; private set; }
    public CombatRank RankID { get; set; }
    public CombatClass CombatClassID { get; set; }

    private T AssignRandomProperty<T>(Random rand)
    {
        int maxSize = Enum.GetValues(typeof(T)).Length;
        int randomIndex = rand.Next(maxSize - 1);
        return (T)Enum.GetValues(typeof(T)).GetValue(randomIndex);
    }

    public PrismID(
        Particle pid,
        Particle hid
    )
    {
        this.Pid = pid;
        this.Hid = hid;

        var rand = new Random();
        this.GenderID = AssignRandomProperty<Gender>(rand);
        this.BirthID = AssignRandomProperty<ZodiacSign>(rand);
        this.NameID = new ParticleNameID(pid, hid);
        this.FamilyID = AssignRandomProperty<QuantumName>(rand);
        this.RaceID = ConfigureRace(pid);
        this.FactionID = hid;
        this.RankID = AssignRandomProperty<CombatRank>(rand);
        this.CombatClassID = AssignRandomProperty<CombatClass>(rand);
    }

    public static RaceID ConfigureRace(Particle pid)
    {
        foreach (RaceID race in Enum.GetValues(typeof(RaceID)))
        {
            int rawRaceIndex = (int)race;
            int rawPidIndex = (int)pid;
            if (rawRaceIndex == rawPidIndex) return race;
        }
        throw new Exception($"CANT FIGURE THE HELL OUT WHY PID ISNT RACE! {pid}");
    }

    public PrismID(
        Particle pid,
        Particle hid,

        QuantumName familyName,
        CombatRank rank,
        CombatClass combatClass
    )
    {
        this.Pid = pid;
        this.Hid = hid;

        var rand = new Random();
        this.GenderID = AssignRandomProperty<Gender>(rand);
        this.BirthID = AssignRandomProperty<ZodiacSign>(rand);
        this.NameID = new ParticleNameID(pid, hid);
        this.FamilyID = familyName;
        this.RaceID = ConfigureRace(pid);
        this.FactionID = hid;
        this.RankID = rank;
        this.CombatClassID = combatClass;
    }

    public PrismID(
        Particle pid,
        Particle hid,

        QuantumName familyId,
        CombatRank rankId,
        CombatClass combatClassId,

        Gender genderId,
        ZodiacSign birthId,

        string firstName = null,
        string lastName = null
    )
    {
        this.Pid = pid;
        this.Hid = hid;

        this.GenderID = genderId;
        this.BirthID = birthId;

        if (
            string.IsNullOrEmpty(firstName) ||
            string.IsNullOrEmpty(lastName)
        )
        {
            this.NameID = new PrismNameID(firstName, lastName);
        }
        else
        {
            this.NameID = new ParticleNameID(pid, hid);
        }

        this.FamilyID = familyId;
        this.RaceID = ConfigureRace(pid);
        this.FactionID = hid;
        this.RankID = rankId;
        this.CombatClassID = combatClassId;
    }
}

