using Assets.SolarConquestModel.Grid;
using SolarConquest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class GalaxyGrid: IGridUpdater
    {
        public IFaction AllyFaction { get; set; }
        public IFaction EnemyFaction { get; set; }
        private List<List<SolarGrid>> galaxyMatrix {  get; set; }

        public void Update()
        {
            foreach (var solarLine in galaxyMatrix)
            {
                foreach (var solarItem in solarLine)
                {
                    solarItem.Update();
                }
            }
        }

        public GalaxyGrid(FederationFaction federationFaction, EmpireFaction empireFaction)
        {
            this.AllyFaction = federationFaction;
            this.EnemyFaction = empireFaction;
            this.galaxyMatrix = new List<List<SolarGrid>>();

            var allySolarGrids = new List<SolarGrid>();
            foreach (var allyFlag  in this.AllyFaction.GetFactionFlags())
            {
                var solarGrid = new FactionSolarGrid();
                allySolarGrids.Add( solarGrid );
            }
            this.galaxyMatrix.Add( allySolarGrids );

            for ( int i = 0; i < 3; i++)
            {
                var solarLine = new List<SolarGrid>();
                for (int j = 0; j < 5; j++)
                {
                    var solarGrid = new SolarGrid();
                    solarLine.Add( solarGrid );
                }
                this.galaxyMatrix.Add(solarLine );
            }

            var enemySolarGrids = new List<SolarGrid>();
            foreach (var enemyFlag in this.EnemyFaction.GetFactionFlags())
            {
                var solarGrid = new FactionSolarGrid();
                enemySolarGrids.Add(solarGrid);
            }
            this.galaxyMatrix.Add(enemySolarGrids);


            //galaxyGrid = new SolarGrid[5,5];
            //foreach (var gridLine in galaxyGrid)
            //{
            //    foreach (var lineElement in gridLine)
            //    {

            //    }
            //}

            // FactionSolarGrid => SolConfiguration
            // Faction gets 4 ArchFactionSolarGrid and 1 AdminFactionSolarGrid
            // mapping is arch, arch, admin, arch, arch
            // map colony to system
            /*
            ex.)
                Admin Faction is Created:
                    - AdminCouncil
                        - ArchCouncil
                        - GuardianOrder
                    - Colonies
                        - Citadel
                        - City
                        - Town
                        - Outpost
                    - Fleets
                        - Elite Fleet
                        - Heavy Fleet
                        - Standard Fleet
                        - Scout Fleet
                    - Squadrons => Per Arch and Admin Faction
                    - Families => Per Arch and Admin Faction and name
                    - Prisms => Per Arch and Admin Faction
                Arch Faction is Created:
                    - Colonies
                        - CitadelCity
                        - City
                        - Town
                        - Outpost
                    - Fleets
                        - Elite Fleet
                        - Heavy Fleet
                        - Standard Fleet
                        - Scout Fleet
                    - Squadrons
                    - Families
                    - Prisms
            */



            /*
                GalaxyGridMatrix:
                    c d e   d e a   e a b   a b c   b c d
                    0 0 0   0 0 0   0 A 0   0 0 0   0 0 0
                    b 0 a   c 0 b   d 0 c   e 0 d   a 0 e

                    0 0 0   0 0 0   0 0 0   0 0 0   0 0 0
                    0 0 0   0 0 0   0 0 0   0 0 0   0 0 0
                    0 0 0   0 0 0   0 0 0   0 0 0   0 0 0

                    0 0 0   0 0 0   0 0 0   0 0 0   0 0 0
                    0 0 0   0 0 0   0 0 0   0 0 0   0 0 0
                    0 0 0   0 0 0   0 0 0   0 0 0   0 0 0

                    0 0 0   0 0 0   0 0 0   0 0 0   0 0 0
                    0 0 0   0 0 0   0 0 0   0 0 0   0 0 0
                    0 0 0   0 0 0   0 0 0   0 0 0   0 0 0

                    y 0 z   x 0 y   w 0 x   v 0 w   z 0 v
                    0 0 0   0 0 0   0 A 0   0 0 0   0 0 0
                    x w v   w v z   v z y   z y x   y x w

                SolarMatrix: Sol[v e m j s n]
                    v0 e1 m2
                    j1 j2 j3
                    s1 s2 n1

                Then:
                    GalaxyGrid: 5x5 SolarGrid, GalaxyMatrix
                    SolarGrid: InnerPlanets, OuterPlanets, SolarMatrix
                        - InnerPlanets
                            - 1-3 LifePlanets
                                - with 0-2 DeadMoon
                        - OutterPlanets
                            - 1-3 GasGiants
                                - with 0-2 DeadOutterPlanetMoons
                                - with 1-3 LifeOutterPlanetMoons

                    FactionGrid:
                        - InnerPlanets: 
                            - LifePlanet Venus-0 DeadInnerPlanetMoons
                            - LifePlanet Terra-1 DeadInnerPlanetMoon
                            - LifePlanet Mars-2 DeadInnerPlanetMoons
                        - OutterPlanets:
                            - GasGiant Jupiter-5 Moons
                                - 2 DeadOutterPlanetMoon
                                - 3 LifeOutterPlanetMoon
                            - GasGiant Saturn-3 Moons
                                - 1 DeadOutterPlanetMoon
                                - 2 LifeOutterPlanetMoon
                            - GasGiant Neptune-1 Moons
                                - 1 LifeOutterPlanetMoon
                            
                    
                    for loaded events:
                        0: Empty Life Planet
                        Passive Events:
                            -1: Empty Life Planet with Survivers
                            Exchange Event:
                                -2: Merchant Outpost
                                -4: Merchant Town
                                -6: Merchant City
                                -8: Exchange CitadelCity
                            Passive Native Event:
                                2: Mediveal Town
                                4: Industrial City
                                6: Primal Outpost
                                8: Urban City

                        Aggressive Events:
                            1: Empty Dead Planet with gravyard of ships and colonies
                            Exchange Event:
                                2: Slaver Town
                                4: Slaver City
                                6: Hunters Outpost
                                8: Hunters City
                            Aggressive Native Event:
                                3: Raiders Outpost
                                5: Raiders Town
                                7: Pirate Town
                                9: Pirate City

                Then
                            

            */
        }
    }
}
/*
 ASCII Galaxy Grid:
                a b c d e
                z y x w u
                1 3 5 7 9
                0 2 4 6 8
                X X X X X

                X means empty Solar System
                numbers are odd for pirates and even for the exchange 
                u-z is empire systems
                z-e is federation systems

                a b c d e
                0 1 2 3 4
                X X X X X
                5 6 7 8 9
                u w x y z

                okay so what if 
                
                federation solar:
                b X d
                X a X
                c X e

                empire solar:
                u X w
                X z X
                x X y

                random solar:
                0 1 2
                3 4 5
                6 7 8

                then we get 3x3 SolarGrid in GalaxyGrid
                so if 4x5 FactionSolarGrids
            
                Sol Configuration: => Per FactionSolarGrid
                - InnerPlanets
                    0 - Venus => 0 Moons
                    1 - Earth => 1 Moon
                    2 - Mars => 2 Moons
                - OutterPlanets
                    3 - Jupiter => 2 DeadMoons, 3 LifeMoons
                    4 - Saturn => 1 DeadMoons, 2 LifeMoons
                    5 - Neptune => 1 Life Moons

                SolarGrid:
                - InnerPlanets
                    - 1-3 inner planets with 0-2 moons each
                - OutterPlanets
                    - 1-3 gas giants with 2-3 Life Moons and 0-2 DeadMoons


                Thus FactionSolarGrid:
                    0 1 2
                    3 4 5
                    6 7 8

                    venus earth mars
                    1st   2nd   3rd  jupiter moon 
     Saturns moons [1st   2nd]  Netptune moon


                Then: ArchFactionSolarGrid

                a b c d e => c b d
                             X X X
                             a X e

                Then: AdminFactionSolarGrid
                A being the Dreadnought/Citadel

                a b c d e => c a d
                             X A X
                             b X e

                Then: 4 ArchFactionSolarGrid + AdminFactionSolarGrid
                    c a d   d b e   e c a   a d b   b e c
                    X X X   X X X   X A X   X X X   X X X
                    b X e   c X a   d X b   e X c   a X d

                    X X X   X X X   X X X   X X X   X X X
                    X X X   X X X   X X X   X X X   X X X
                    X X X   X X X   X X X   X X X   X X X

                    X X X   X X X   X X X   X X X   X X X
                    X X X   X X X   X X X   X X X   X X X
                    X X X   X X X   X X X   X X X   X X X

                    X X X   X X X   X X X   X X X   X X X
                    X X X   X X X   X X X   X X X   X X X
                    X X X   X X X   X X X   X X X   X X X

                    c a d   d b e   e c a   a d b   b e c
                    X X X   X X X   X A X   X X X   X X X
                    b X e   c X a   d X b   e X c   a X d

                Then:
 */
