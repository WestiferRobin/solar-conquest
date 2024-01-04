
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

    - PrismBlueprint: RobotComponents, OrganicComponents
        - Cells: Animal or Plant
            - Produce Organic Chemicals from DNA
        - CellChunk => CellArea
        - CellArea => BodySkin
        - CellVolume => BodyParts

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

    public enum ZodiacSign
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
        Socialize = 0, // All Prisms talk to each other based on interaction score. combat rank pushes range
        Combat = 1, // All Prisms can fight. which means it's level cap is Admin
        Bredding = 2, // All Prisms can breed but doesn't count. Has it's own compatibility score
    }

    /*
    Prism Skills:
        - Combat Skill => kills per battle
            - Shooting
            - Melee
            - Ship Weapons
            - Pilot of Craft to Vehicle or Ship Captin per Vehicle
        - Labor Skills
            - Cleaner
            - Mechanic
            - Cooking
            - Construction
        - Harvester Skills => 
            - Mining
            - Farming
            - Animals
            - Hunting
        - Crafting
            - Construction
            - Armor
            - Weapons
            - Tools
        - Social
            - Friendly => Charisma
            - Funny => Charisma
            - Romantic => Breeding
            - Mean => Provoke Battle
        - Intellectual => Logic
            - Engineering => Vehicle Upgrades, Prism Upgrades, Robotics
            - Piloting => LandSpeeders, SpaceFighters, and Shuttles
            - Medical => Medicine, Stim, Genetics
            - Leadership => Running Armadas, Colonies, and Factions
            - Ship Skills
                - Engine Skills
                - Shield Skills
                - Craft Skills
        - Magi Order => Magic Skill but define FotF order
            - Federation => Guardian Order
                - Delta => Light Angle Magic with PlasmaBo
                - Lambda => Yellow Electric Magic with PlasmaKatana
                - Alpha => Red Fire Magic with PlasmaSpear
                - Gamma => Green Life Magic with PlasmaKatana
                - Beta => Blue Water Magic with PlasmaRapier
            - Empire => Necromancery: Wraith Order
                - Omega => Dark Demon Magic with PlasmaClaymore
                - Psi => Purple Electric Magic with PlasmaLongsword
                - Theta => Cyan Water Magic with PlasmaHammer
                - Phi => Magennta Phycic Magic with PlasmaLongsword
                - Sigma => Orange Healing/Enchantment Magic with PlasmaKhopesh
            - Magi Order Weapon Types
                - Models
                    - Swords
                        - Khopesh
                        - Katanna
                        - Longsword
                        - Cutlass
                        - Rapier
                        - Claymore
                    - Staffs
                        - BattleAxe
                        - BattleHammer
                        - BattleBo
                        - BattleSpear
                - Types
                    - Stone => Primitive
                    - Metal => Industrial Status
                    - Laser => Digital Status
                    - Plasma => Space Status


    - HOLD: NEEDS TO MOVE TO NEW FILE LOCATIONS
        - Federation rules by Lambda
            - Lambda rules from Earth the Capital of the Federation
                - Atlantian Guardian Order is on Dreadnought on Titan
            - Martians, Venatoans, and Nepatoans are Embassy Colonies
                - Martians Embassy
                - Venatoan Embassy
                - Nepatoan Embassy
                - Atlantian Embassy => Dreadnought and Citadel

        - Colonies
            - Status
                - Primitive: Primitive tools, Primitive Power
                - Industrial: Steal tools, Steam Power
                - Digital: Laser tools, Solar Power
                - Space: Plasma tools, Nuclear Power
            - Outpost => 1 Hedron
            - Town => 2 Hedron, StandardFleet
            - City => 3 Hedron, HeavyFleet
            - Space Types Only
                - Arch Citadel => 4 Hedorn, ArchEliteFleet
                - Admin Citadel => 5 Hedron, AdminEliteFleet


    Rimworld Skills:
        - Shooting
        - Melee
        - Construction
        - Mining
        - Cooking
        - Plants
        - Animals
        - Crafting
        - Artistic
        - Medical
        - Social
        - Intellectual

    FTL Skills:
        - Piloting skill
        - Engines skill
        - Weapons skill
        - Shields skill
        - Repair skill
        - Combat skill
        - Skills table

    Sims Skills:
        - Social Interactions => Charisma is the skill for more options
        - Skill per Item, Furniture, or Social Interaction
 
    */
}