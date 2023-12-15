# SolarDataModel

This is for game datamodel that unity interacts with. Think of it as the databus for the game to run in whatever situation and has mod support.


# Game
Game has 2 Players
- User "Wes" Scenario:
    - UserPlayer => Federation
    - AIPlayer => Empire
- AI Scenario:
    - AIPlayer => Federation
    - AIPlayer => Empire

SolarConquestGameEndpoint: /Game/Player/{player_id}/{default: 0 but saved game}

Federation/Admin/Guardian
Federation/Archs/{ArchFlag}/Guardian

Federation of the Federation Order:
    - Federation Admin
    - Federation Guardians
    - Federation Archs
        - ViceArch: Atlantian Quazar Family
        - GeneralArch: Terrian Photon

Federation/AdminOrder
    - Admin
    - Admin Guardian
    - Vice Admin => ArchFaction for AdminFaction
Federation/GuardianOrder
    - Admin Guardian
    - All Arch Guardians
Federation/ArchOrder
    - Vice Admin
    - All Archs
    - All Arch Guardians

GovernmentEndpoint: 
Gov = {Federation, Empire, Exchange, Pirates}
FactionFamilyFlags = {
    AdminFamilyFlag: Delta Delta => Male
    GuardianOrderFlag: Mu Mu => Female
    ArchRaceFamilies: {
        - Key: CombatRank-ArchRace-CombatClass Family
        ArchDeltaQuazarFamily: {
            ViceLeaderFlag: Delta Delta => Female
            ViceGuardianFlag: Delta Mu => Male
            Children:
                - Delta Delta Male: Vice Leader Delta
                - Delta Mu Male: Major Mu
                - Delta Delta Female: Major Delta
                - Delta Mu Female: Vice Guardian Mu
        }
        ArchLambdaElectronFamily: {
            ArchLeader: Lambda Lambda => Female
            ArchGuardian: Lambda Mu => Male
            Children:
                - Lambda Lambda Male: Vice Leader Lambda
                - Lambda Mu Male: Gold Guardian Mu
                - Lambda Lambda Female: Major Lambda
                - Lambda Mu Female: Major Mu
        }
        ArchAlphaProtonFamily: {
            ArchLeader: Alpha Alpha => Male
            ArchGuardian: Alpha Mu => Female
            Children:
                - Alpha Alpha Male: Vice Leader Alpha
                - Alpha Mu Male: Ruby Alpha
                - Alpha Alpha Female: Vice Guardian Mu
                - Alpha Mu Female: Ruby Guardian Mu
        }
        ArchGammaPhotonFamily: {
            ArchLeader: Gamma Gamma => Male
            ArchGuardian: Gamma Mu => Female
            Children:
                - Gamma Gamma Male: Vice Leader Gamma
                - Gamma Mu Male: Emereald Gamma
                - Gamma Gamma Female: Vice Guardian Mu
                - Gamma Mu Female: Emereald Guardian Mu
        }
        ArchBetaNeutronFamily: {
            ArchLeader: Beta Beta => Female
            ArchGuardian: Beta Mu => Male
            Children:
                - Beta Beta Male: Vice Leader Beta
                - Beta Mu Male: Saphirerr Guardian Beta
                - Beta Beta Female: Vice Guardian Mu
                - Beta Mu Female: Saphirerr Guardian Mu
        }
    }
}

ArchRaceFamilies = {
    AdminFamily => DeltaFamily => DeltaAdminArchFamily
        - Arch Family:
            - DeltaFamily
            - LambdaFamily
            - AlphaFamily
            - GammaFamily
            - BetaFamily
    QuazarFamily => DeltaQuazarArchFamily
        QuazarFamily => DeltaFamily => ArchFamily
            - Families:
                - DeltaElectronArchFamily
                - DeltaProtonArchFamily
                - Delta
    ElectronFamily => LambdaFamily => LambdaElectronArchFamily
    ProtonFamily => AlphaFamily => AlphaProtonArchFamily
    PhotonFamily => GammaFamily => PhotonGammaArchFamily
    NeutronFamily => BetaFamily => NeutronBetaArchFamily
}


AdminFaction = {
    FactionOrder:
        - Admin: AdminLeader: DeltaLeader
        - RoyalFamily => FactionFamily:
            - AdminFamily => Admin Leader and Admin Guardian makes Guardians which breeds with ArchFamilies where Arch Family is a part of ArchFamilies
            - ArchFamilies to CombatClass Families
                - ViceFamily => ArchFamily => [ArchFamily => [QuazarFamily, ElectronFamily PhotonFamily, ProtonFamily, NeutronFamily]] => DeltaLeaderFamily to DeltaQuazarFamily
                - LambdaFamily => ArchFamily => LambdaLeaderFamily to LambdaElectronFamily
                - AlphaFamily => ArchFamily => AlphaLeaderFamily to AlphaProtonFamily
                - GammaFamily => ArchFamily => GammaLeaderFamily to 
                - BetaFamily => ArchFamily => BetaLeaderFamily
        - GuardianOrder:    
            - AdminGuardian: DeltaGuardian
            - GuardianSquadron:
                - WhiteGuardian: ViceGuardian: DeltaGuardian
                - YellowGuardian: LambdaGuardian
                - RedGuardian: AlphaGuardian
                - GreenGuardian: GammaGuardian
                - BlueGuardian: BetaGuardian
            - DiscipleSquadrons:
                - Color Guardian
                - Those who match color power
        - ArchOrder:
            - LeaderSquadron
                - ViceLeader: DeltaArchLeader
                - Arch Leaders:
                    - LambdaLeader
                    - AlphaLeader
                    - GammaLeader
                    - BetaLeader
            - GuardianSquadron:
                - ViceGuardian: White Guardian
                - LambdaGuardian: Yellow Guardian
                - AlphaGuardian: Red Guardian
                - GammaGuardian: Green Guardian
                - BetaGuardian: Blue Guardian
    ArchFaction(ViceAdmin, ViceGuardian):
        - Arch Capital => Faction Citadel
        - Elite Fleet => Guardian Fleet
    FactionFleet:
        - AdminFleet => Dreadnought and 2 Capital Ships => Royal Fleet => AdminLeader
        - GuardianFleet => 1 CapitalShip and 2 Freighter Ships => Elite Fleet => AdminGuardian and GuardianOrder
        - FactionFleet => All of Arch's FactionPopulationFleets
    FactionPopulation: => ALL OF ARCH POPULATION
}
ArchFaction = {
    Family Population:
        - Arch Families => Royale Family of Faction
        - Arch Quazar Families
        - Arch Electron Families
        - Arch Proton Families
        - Arch Photon Families
        - Arch Neutron Families
    Fleet Population:
        - Elite Fleet
            - ArchGuardian: Protector of Arch Faction
        - Heavy Fleet
            - ArchCaptian
        - Standard Fleet
            - ArchAdmiral
        - Standard Fleet
            - ArchAdmiral
        - Light Fleet
            - ArchAdmiral
    Colony Population:
        - Arch Capital => Arch Homeworld ex.) Terrian Faction's homeworld is Earth
            - ArchLeader: Leader of the Faction
        - Arch City:
            - Arch
        - Arch Town:
        - Arch Town:
        - Arch Outpost
    Planet Population:
        - Arch Homeworld => Arch Capital Colony ex.) Earth for Terrian Arch Faction
        - Arch City Colony => CityColony on Face of PlanetSide of LifePlanet or LifeMoon
        - Arch Town Colony => TownColony on Face of PlanetSide of LifePlanet or LifeMoon
        - Arch Outpost Colony => OutpostColony on Face of PlanetSide of LifePlanet or LifeMoon
}

