using System;
using System.Collections.Generic;

public class Prism
{
    public PrismID Pid { get; private set; }
    public PrismID Hid { get; private set; }
    public string FirstName { get; private set; }
    public string FamilyName { get; private set; }
    public Horoscope BirthSign { get; private set; }
    public PrismGender Gender { get; private set; }
    public Dictionary<PrismBodyPart, int> Body { get; private set; }
    public Dictionary<PrismID, int> HedronNetwork { get; private set; }
    public Dictionary<PrismSkillID, int> Skills { get; private set; }

    public string ToJson()
    {
        // TODO: FIX THIS SHIT WITH UNITY
        var json_data = new
        {
            pid = Pid.ToString(),
            gender = Gender.ToString(),
            name = $"{FirstName} {FamilyName}",
            body = Body,
            hedron_network = HedronNetwork,
            skills = Skills
        };
        return Pid.ToString();
        //return JsonConvert.SerializeObject(json_data);
    }

    public Prism(
        PrismID pid = PrismID.Omega,
        PrismID hid = PrismID.Mu,
        string first_name = null,
        string family_name = null,
        Horoscope? birth_sign = null,
        PrismGender? gender = null,
        Dictionary<PrismBodyPart, int> body = null,
        Dictionary<PrismID, int> hedron_network = null,
        Dictionary<PrismSkillID, int> skills = null
    )
    {
        this.Pid = pid;
        this.Hid = hid;

        this.FirstName = first_name ?? pid.ToString();
        this.FamilyName = family_name ?? hid.ToString();
        this.BirthSign = birth_sign ?? (Horoscope)new Random().Next(0, 11);
        this.Gender = gender ?? (PrismGender)new Random().Next(0, 2);

        this.Body = body ?? CreatePrismBody();
        this.HedronNetwork = hedron_network ?? new Dictionary<PrismID, int>();
        this.Skills = skills ?? CreatePrismSkills();
    }

    public override string ToString()
    {
        var is_alive = isAlive() ? "alive" : "dead";
        return $"{Pid}:{FirstName}:{Gender}:{is_alive}";
    }

    public bool isAlive()
    {
        return Body[PrismBodyPart.Head] > 0 && Body[PrismBodyPart.Torso] > 0;
    }

    public Family breed(Prism parent1, Prism parent2)
    {
        var gender = (PrismGender)new Random().Next(0, 2);
        var pid = gender == PrismGender.Female ? parent1.Pid : parent2.Pid;
        var hid = gender == PrismGender.Male ? parent1.Hid : parent2.Hid;
        var first_name = gender == PrismGender.Male ? parent1.FirstName : parent2.FirstName;
        var family_name = gender == PrismGender.Male ? parent1.FamilyName : parent2.FamilyName;
        var birth_sign = (Horoscope)new Random().Next(0, 12);

        var father = parent1.Gender == PrismGender.Male ? parent1 : parent2;
        var mother = parent2.Gender == PrismGender.Female ? parent2 : parent1;
        var children = new List<Prism> { new Prism(pid, hid, first_name, family_name, birth_sign, gender) };
        return new Family(
            father,
            mother,
            children
            );
    }

    public bool knows(Prism target)
    {
        return HedronNetwork.ContainsKey(target.Pid);
    }

    public void socialize(Prism target)
    {
        if (knows(target) && target.knows(this))
        {
            var social_limits = CalculateSocialLimits(this, target);
            var social_score = new Random().Next(social_limits.Item1, social_limits.Item2 + 1);

            HedronNetwork[target.Pid] += social_score;
            if (HedronNetwork[target.Pid] <= -100)
                HedronNetwork[target.Pid] = -100;
            if (HedronNetwork[target.Pid] >= 100)
                HedronNetwork[target.Pid] = 100;

            target.HedronNetwork[Pid] += social_score;
            if (target.HedronNetwork[Pid] <= -100)
                target.HedronNetwork[Pid] = -100;
            if (target.HedronNetwork[Pid] >= 100)
                target.HedronNetwork[Pid] = 100;
        }
        else
        {
            HedronNetwork[target.Pid] = 0;
            target.HedronNetwork[Pid] = 0;
        }
    }

    private static Dictionary<PrismBodyPart, int> CreatePrismBody()
    {
        return new Dictionary<PrismBodyPart, int>
        {
            { PrismBodyPart.Head, 5 },
            { PrismBodyPart.Torso, 7 },
            { PrismBodyPart.Arms, 4 },
            { PrismBodyPart.Legs, 4 }
        };
    }

    private static Dictionary<PrismSkillID, int> CreatePrismSkills()
    {
        var skills = new Dictionary<PrismSkillID, int>();
        foreach (PrismSkillID skill_tag in Enum.GetValues(typeof(PrismSkillID)))
        {
            skills.Add(skill_tag, 0);
        }
        return skills;
    }

    private static Tuple<int, int> CalculateSocialLimits(Prism prism1, Prism prism2)
    {
        // Implement your logic for social limits calculation here
        return Tuple.Create(0, 100);
    }
}

public class Family
{

    public Prism father { get; private set; }
    public Prism mother { get; private set; }
    public List<Prism> children { get; private set; }

    public Family(Prism father, Prism mother, List<Prism> children = null)
    {
        this.father = father;
        this.mother = mother;
        this.children = children ?? new List<Prism>();
    }
}
