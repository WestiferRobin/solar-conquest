

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

Particles:
    Particles are from my SoverignParticle Research
    Particles are matrixed greek variables assigned to a matrix index
    Max Particles is 12 so can do a 12 by 12 ParticleArea: IArea
    REMEMBER that GodParticles "Spooky Stuff" occurs on a SoverignTesseract
    Thus means a ParticleTesseract
    - ParticleTesseract: All 12 Particles or a PrismHedron => [PrismSquadron, PrismFamily, PrismCouncil]
        - 9 DefaultParticles
            - Face: DefaultFaceConfiguration
                - Alpha Gamma Beta
                - Sigma Delta Psi
                - Theta Phi Lambda
        - 4 ParameterParticles
            - Face: ParameterFaceConfiguration: Particle
                - FaceVector: ParticleVector3D(Omega, Mu, Epsilon) 

    NOTE: A Tesseract Shadow is a Levithan to a ParticleTesseractFace
        - A Levithan is one inner and outer ParticleCube
        - ParticleCube: ICube
        - ITesseractFace:
            - Edges: List<ITesseractEdge>
            - Verticies: List<ITesseractVertex>
        - ICube: ITesseractFace
            - DimensionSize
            - Faces: List<ICubeFace>
        - ICubeFace: IFace
            - Edges: List<ICubeEdge>
            - Verticies: List<ICubeVertex>


        - XDimensionPolygon: IPolygon
            - ParticleFace: IFace
                - Edges: List<IEdge>
                - Verticies: List<IVertex>
            - ParticleEdge: IEdge
                - SourceVertex: IVertex
                - TargetVertex: IVertex
            - ParticleVertex: IVertex:
                - ParticlePoint: IPoint
            - ParticlePoint: IPoint:
                - ParticleHedron: Hedron with Particles to a Prism

        - 4DimensionPolygon: XDimensionPolygon(4)
        - 3DimensionPolygon: XDimensionPolygon(3)
            - Cube
            - Sphere
        - 2DimensionPolygon: XDimensionPolygon(2)
            - DimensionLine: DimensionEdge: IEdge
            - DimensionFaceShapes: IFace, IShape
                - Square
                - Circle
                - Triangle
        - 1DimensionPolygon: XDimensionPolygon(1)
            - DimensionPoint: IPoint

        - ParticlePolygon: 4DimensionPolygon, 3DimensionPolygon, 2DimensionPolygon, 1DimensionPolygon
            - ParticlePolygons: 1DDimensionPolygon
                - ParticlePoints: List<IPoint>
            - ParticlePolygons: 2DDimensionPolygon
                - ParticleCircle: IPolygonCircle
                - ParticleSquare: IPolygonRectange
                - ParticleTriangle: IPolygonTriangle
            - ParticlePolygons: 3DDimensionPolygon
                - ParticleCube: IPolygonCube
                - ParticleSphere: IPolygonSphere
                - ParticlePyramid: IPolygonPyramid
                    - ParticlePyramidTriangle: IPolygonTrianglePyramid
                    - ParticlePyramidSquare: IPolygonSquarePyramid
            - ParticlePolygons: 4DimensionPolygon
                - Tesseract: LevithanShadown: ITesseractFace

        - ParticlePolygons
            - 4DimensionParticlePolygons: Particle Tesseract with ITesseractSides
            - 3DimensionParticlePolygons: Particle [Cube, Sphere, TriPyramid, RectPyarmid]
            - 2DimensionParticlePolygons: Particle [Square, Circle, Triangle]
            - 1DimensionParticlePolygons: Particle [Point]

        <!-- - ParticleGrid: ParticleModel, IGrid
            - ParticleGridComponent: IGridComponent
            -  -->
        - PolygonGrid(polygon, grid):
            - IPolygon: polygon
            - IGrid: grid
        - LevithanTesseractGrid: PolygonGrid(LevithanTesseract(), ParticleGrid())
        - LevithanTesseract(LevithanShadow()): ParticleTesseract
        - LevithanShadow: ITesseractFace
        - ParticleTesseract: 4DimensionParticlePolygon

        - GridComponent: IGrid is the IPolygon for InterfaceComponents
            - IGridSide: ISide is the IFace of a GridComponet
            - ISideArea: IArea is the IFace of a GridSideComponent
            - IChunkArea: IChunk is the IFace of a GridSideAreaComponent
            - IChunkTile: ITile is the IFace of a ChunkAreaComponent
        
        Hypothisis is that Earth lives in a Sea of LevithanShadow caused by mechanics of a 4DimensionParticlePolygon
        So GalaxyBoard in SolarConquestModel is modeled off a LevithanShadown the face of a 4DimensionParticlePolygon

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

