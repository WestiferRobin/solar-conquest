

UnityScripts:
    Managers: => Will need to move to a new repo or to mu-prism
        ParticleEngineManager => Manages ParticleEngine playing ParticleGames like SolarConquest
        GameObjectManager => Manages Unity's GameObjects
        IManager => Manages Unity's GameScenes

Components:
    - EngineComponents:
        - IEngineComponent
        - EngineModelComponent: ModelComponent, IEngineComponent
    - GameComponents:
        - IGameComponent
        - GameModelComponent: ModelComponent, IGameComponent
    - SolarConquestComponents:
        - SolarConquestComponent: GameModelComponent
    - IModel
    - IComponent
    - ModelComponet: IModel, IComponent

Games: ParticleGame => PrismAI running on ParticleEngine in a ParticleGame: ParticleApp
    - ParticleGame: GameModel, IGame
    - SolarConquestGame: ParticleGame
    - IGame
    - GameComponent: GameModelComponent(GameModel: IGame)
            - SolarConquestComponent: GameComponent(SolarConquestGame())
    - ParticleGameComponent(ParticleGameModel): GameComponent(ParticleGameModel)
    - SolarConquestGameComponent: ParticleGameComponent(SolarConquestModel)


Engines:
    GameEngines:
        - AbstractGameEngine: IGame, IEngine
            - GameEngineComponent
            - GameComponent
        - ParticleEngine: GameEngine
            - ParticleEngineComponent: GameEngineComponent
            - ParticleGameComponent: GameComponent
    - IEngine








SolarConquestComponents

    Game: GameComponents
        - PlayerComponets
            - WhiteChessPieceComponets => FederationFaction
            - BlackChessPieceComponets => EmpireFaction
        - GameBoardComponet => GalaxyBoard

    SolarConquest: SolarConquestComponents
        - PlayerComponents
            - FederationPieces
            - EmpirePieces
        - BoardComponents
            - GalaxyComponent: GalaxyBoard
                - SolarComponents
                    - SolarSystem
                        - InnerPlanets
                            - InnerPlanet: InnerPlanetComponent()
                        - OuterPlanets
                            - OuterPlnet: OuterPlanetComponent()
                        - Planet: PlanetComponent
                            - Moons: [ X Moon: MoonComponent ]
                            - LandTiles: LandPlanetComponent
                            - SpaceTiles: SpacePlanetComponent
                        - Moon: MoonComponent
                            - LandTiles: LandMoonComponent
                            - SpaceTiles: SpaceMoonComponent
                        - GasPlanet: GasPlanetComponent
                            - SpaceTiles: SpaceGasGiantComponent



    GalaxyBoard: GalaxyBoardComponent
        - SolarHedron of SolarComponents => 5 x 5, 3 x 3 x 3, [x, y, z, w]
        - PlanetHedron in SolarComponent
        - MoonHedron is a PlanetHedron without Moons (or maybe astroids? => Life Astroids occoring only 0.5 to 1 percent?)
        - MoonComponent is a PlanetComponent
        - PlanetComponent has a LandComponent, SpaceComponent
        - A Planet has sides (imagine the globe as a minecraft globe)
            - Side has a Grid of Areas that contain Particle x Particle Chunks
            - Particle Chunk is a 12 x 12 TileChunk of ParticleTiles
            - PlanetComponent
                - PlanetSides
                    000
                    000
                    000 => 3 x 3 Grid of LandAreas which has (3 * 3 Grid of Area) * Particle x Particle Chunks 
                    9 Grid of LandAreas * 12 x 12 TileChunk of ParticleTiles => 1296 Grid of LandTiles
                - GetPlanetSides
                    - GetLandSides
                    - GetSpaceSides
                    - GetAllSides
            - SpacePlanetSideComponent: PlanetComponent
                - SpacePlanetSide
            - LandPlanetSideComponent: PlanetComponent
                - LandPlanetSide



        
    GalaxyBoard: IBoard
        SolarSideComponent x 5 x 5

    or what about final product of 3 x 3 x 3 SolarSideComponent
    or think about how Boards are made out of Wood and Steel Compents
    think of a IBoard having IBoardComponents

    Galaxies are made up of solar systems
    Solar Systems are made up of Planets
    Planets are made up of Moons
    Both Planets and Moons that are Dead or Alive have Space and Land 
    GasPlanets only have Space with Land as an instant death











    Galaxy => Solar => Planet
    Side => Grids
    Grid => Areas
    Area => Chunks
    Chunk => Boards
    Board => BoardLayers
    BoardLayer => TileLayers
    TileLayer => Tiles
    Tile => GameTile

