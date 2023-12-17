
namespace SolarConquestGameModels
{
    public enum PrismBodyPartOld
    {
        Head = 0,
        Torso = 1,
        Arms = 2,
        Legs = 3
    }

    public enum PrismBodyPart
    {
        Head,
        Torso,
        Arm,
        Leg
    }
    // Think about RIMWORLD
    /*

    So it's detailed like femur fingers and shit so lets do it

    - Head
        - Mussel
            - Eyes => Crafting
                - LeftEye
                - RightEye
            - Nose => Cooking and Hunting
            - Mouth => Socializing and Breeding
                - Teeth
                - Tounge
        - Skull
            - Brain => Living and Research
    - Torso
        - TorsoMussel
        - RibCage
            - Heart => Living
            - Lungs => Living
            - Kidneys => Alchol
            - Stomach => Hunger
    - 2 Arms
        - Arm
            - ArmMussels
            - ArmBones
            - Hand
                - 5 MusselFingers
                - 5 BoneFingers
    - 2 Legs
        - Leg
            - LegMussels
            - LegBones
            - Foot
                - 5 MusselToes
                - 5 BoneToes

    */

    public enum Gender
    {
        Female = 0,
        Male = 1
    }

    public enum BirthSign
    {
        Capricorn = 0,
        Aquarius = 1,
        Pisces = 2,
        Ares = 3,
        Taurus = 4,
        Gemini = 5,
        Cancer = 6,
        Leo = 7,
        Virgo = 8,
        Libra = 9,
        Scorpio = 10,
        Sagittarius = 11
    }

    public enum PrismSkillID
    {
        Socialize = 0,
        Combat = 1,
        Bredding = 2,
    }
}