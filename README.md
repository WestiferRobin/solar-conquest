# SOLAR CONQUEST


## TODOS:
1. Make full galaxy grid without factions
2. Add factions into the grid
    - Per PlayerFaction
        - Per RaceFaction
            - Planet
                - CityColony
                - HeavyFleet
            - Planet
                - ArchCityColony
                - EliteFleet
            - Planet
                - TownColony
                - StandardFleet
            - Planet
                - OutpostColony
                - Light Fleet
            - Planet
                - OutpostColony
                - Light Fleet
3. Write BattleViews => Unit Tests and Integration Tests
    - SquadronVsSquadron
        - PrismVsPrism
        - HedronVsHedron
    - VehicleVsVehicle
        - ShipVsShip
        - SpaceCraftSquadronVsSpaceCraftSquadron
        - LandCraftSquadronVsLandCraftSquadron
        - ShipVsSpaceCraftSquadron
        - SpaceCraftSquadronVsLandCraftSquadron
    - FleetVsFleet
    - PlanetVsPlanet
    - SolarVsSolar
    - FactionVsFaction
4. Build and Apply into Unity
5. Make the Genisis V story in FotF into SolarConquest



### Total Factions and races
#### The Solar Federation
About:
    - Background
        - Humans joined the Solar Federation Offering Planets for resources
        - Human Leader => Human Arch on the Solar Council
    - Faction View
        - Admin Citadel
            - Admin Family
                - Admin Arch
                - Vice Arch
                - Children
                    - White Guardian
                    - Admin Citizen
                    - Admin Citizen
                    - Admin Citizen
            - Solar Council:
                - Admin Arch: Atlantian Angel Leader
                    - Terrian Arch: Terrian Leader
                    - Martian Arch: Martian Leader
                    - Venatoian Arch: Venatoian Leader
                    - Neptonain Arch: Neptonain Leader
                - White Guardian: Atlantian Angel
        - Guardian Dreadnought
            - Guardian Order:
                - White Guardian: Atlantian Angel
                    - Red Guardian: Martian Grey
                        - Red Disciple
                        - Red Disciple
                    - Yellow Guardian: Terrian
                        - Yellow Disciple
                        - Yellow Disciple
                    - Green Guardian: Venatoian
                        - Green Disciple
                        - Green Disciple
                    - Blue Guardian: Neptonain
                        - Blue Disciple
                        - Blue Disciple
        - Arch Faction => 
            - Arch Families
                - Quazar Family => Arch Guardian Family
                - Photon Family => Faction Arch Leader Family
                - Electron Family => Faction Arch Major Son:Daughter Family
                - Neutron Family => Faction Arch Colonel Son:Daughter Family
                - Proton Family => Faction Arch Captian Son:Daughter Family
            - Arch Population of X Families
                - Gen-0: Faction Arch: Faction Leader
                - Gen-1: Faction 1st Son Major
                - Gen-2: Faction 2nd Son Colonel
                - Gen-3: Faction 3rd Son Captain
                - Gen-4: Faction 4th Son Commander
                - Gen-5: Faction 5th Son Lieutenant
                - Gen-6: Faction 6th Son Ensign
                - Gen-7: Faction 7th Son Sergeant
                - Gen-8: Faction 8th Son Lance
                - Gen-9: Faction 9th Son Corporal
                - Gen-10: Faction 10th Son Private
                - Gen-12: Faction 11th Son Citizen
                - Thus => 25 years * 1 Generations * 12 Arch Family Tree => 300 Generations of the Solar Empire since Humans Joined in 2023 (or current year).
            - Ships:
                - Capital Ship => Captian Prism => 4 Hedrons
                    - 4 Crew => 4 * 12 Prisms => 4 PrismHedron
                        - ShipCrew
                            - 1 Captian Prism
                            - 1 Commander Prism
                            - 3 Lieutenant Prism
                            - 3 Sergeant Prism
                            - 4 Ensign Prism

                        - FighterCrew
                            - 1 Lieutenant Prism
                            - 1 Commander Prism
                            - 3 Sergeant Prism
                            - 3 Lance Prism
                            - 4 Corporal Prism

                            - 1 Ensign Prism
                            - 1 Commander Prism
                            - 3 Sergeant Prism
                            - 3 Lance Prism
                            - 4 Corporal Prism

                        - ShuttleCrew
                            - 1 Ensign Prism
                            - 1 Commander Prism
                            - 3 Sergeant Prism
                            - 3 Lance Prism
                            - 4 Corporal Prism
                - Frigate => Commander Prism => 3 Hedrons
                    - 3 Crew => 3 * 12 Prisms => 3 PrismHedron
                        - ShipCrew
                            - 1 Commander Prism
                            - 1 Lieutenant Prism
                            - 3 Lance Prism
                            - 3 Corporal Prism
                            - 4 Private Prism

                        - FighterCrew
                            - 1 Lieutenant Prism
                            - 1 Sergeant Prism
                            - 3 Lance Prism
                            - 3 Corporal Prism
                            - 4 Private Prism

                        - ShuttleCrew
                            - 1 Ensign Prism
                            - 1 Lieutenant Prism
                            - 3 Sergeant Prism
                            - 3 Lance Prism
                            - 4 Private Prism
                - Corvette => Lieutenant Prism => 2 Hedron
                    - 2 Crew => 2 * 12 Prisms => 2 PrismHedron
                        - FighterSquadron
                            - 1 Lieutenant Prism => ShipBridge
                            - 1 Sergeant Prism
                            - 3 Lance Prism
                            - 3 Corporal Prism
                            - 4 Private Prism

                        - ShuttleSquadron
                            - Ensign Prism => ShuttlePilot and ShipWeapons
                            - 1 Sergeant Prism
                            - 3 Lance Prism
                            - 3 Corporal Prism
                            - 4 Private Prism

                - Freighter => Engsin Prism => 1 Hedron
                    - 1 Crew => 1 * 12 Prisms => 1 PrismHedron
                        - 1 Ensign Prism
                        - 1 Sergeant Prism
                        - 3 Lance Prism
                        - 3 Corporal Prism
                        - 4 Private Prism

                        - ShuttleSquadron
                            - Sergeant => ShuttlePilot and ShipWeapons
                            - PrismSquadron
                                - Corporal => SquadronLeader
                                - Private
                                - Private
                                - Private
                                - Private
                        - SpeederSquadron
                            - Lance => SquadronLeader
                            - Corporal
                            - Corporal
                        - ShipCrew
                            - Ensign => ShipBridge
                            - Lance => ShipEngines
                            - Lance => ShipShields
            - Colonies:
                - Capital City => Arch Leader Family
                - City => Major Prism & Family
                - Town => Colonel Prism & Family
                - Outpost => Captian Prism & Family
                - Camp => Commander Prism & Family
Faction Races:
    - Delta: Atlantians => Angel Elves/Kryptoneans
    - Lambda: Terrians => Humans
    - Alpha: Martians => Invinsible Maritans/Orcs
    - Gamma: Venatoians => Quarians/Twlicks
    - Beta: Neptonians => Chiss/Blue Elves












