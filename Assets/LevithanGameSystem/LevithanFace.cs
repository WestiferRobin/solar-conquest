using SoverignParticles;

namespace SolarConquestGameModels
{
    public interface IFace { }
    public class LevithanFace: IFace
    {
        public IComponent FaceComponent { get; set; }
        public IEngine Engine {  get; set; }

        public LevithanFace() { }
    }

    public class ParticleFace: IParticle, IFace
    {
        public IComponent Component { get; }
        public ParticleFace(Particle pid) { 
            ParticleID = pid;
            this.Component = new ParticleApp(pid);
        }

        public Particle ParticleID { get; }
    }

    public class LevithanFaceComponent: ParticleFace
    {
        public LevithanFaceComponent(): base(Particle.Omega) { }
    }

    /*
        So were back in buisness cause my Particles are being used for SolarConquest
        God/Soverign Particles with one being a joke and other being official
        Idea is that SquareGrid of Points can be any matrix including identiy matrix
        I made Greek Letter Set with template ideas including SolarConquest's AI, Story, and Board

        COLOR IDENTIY MATRIX: r == a cause red == alpha
        r g b
        o w p
        c m y

        So if you have an Identiy Matrix what would a Tesseract Matrix look like in 2D, 3D, 1D projections from SoverignParticles
            - Idea is taking MultiVariable Calculus, Physics, Complex Equations, and Chemistry it can be a DataVisualation to any Dimension per Projection (3-1 Space)
            - In looking at Creating FotF with my Equations I liked SolarConquest as a FotF Playground with it's own ideas create FotF.
        Short answer very interesting and explorering the 4D plus Dimension with a ParticleEngine

        SolarConquestGame => SoverignParticles
    
        With Scientific and Entertainment purposes, my SoverignParticle Research will make my LevithanEngine
            - Scienctific Purpose: See Projections of 4D Systems to apply in Computational Classical Mechanics, Genetics, and Chemistry Experiements
                - Goal: Make a SolarSystem mapped to a ParticleGrid
            - Entertainment Purpose: See my Star Wars at rated R => Blood, Tears, and Gore in War
    
        WHAT IS LEVITHAN SHADOW:
            WHAT IS A LEVITHAN:
                - Levithan is the name of the ParticleEngine to compute SoverignParticles
                - A Levithan is also a Tesseract so a ParticalPolygon: ParticalGrid
                - The belief is that the Tesseract's Face can show the Earth in the Solar System
                - Curiosity is that the engine calculations will show weird patterns from stairing it's Shadow: TesseractFace
            WHAT IS A SHADOW:
                - A Shadow is the Face of a Tesseract, and it's not that crazy
                - A Tesseract 3D Face is just 2 Grid Cubes => ParticleGridCube => Tesseract: ParticleTesseract: [InnerPolygon, OuterPolygon]: PolygonGrid
            
            So by comparison we can see Projections D n-1 to 1 times for DimensionPolygons: ParticlePolygons => ParticalTesseract with a LevithanFace
            DimensionShape
            - Dim0 to Dim1: Existance or not
                - ZeroPoint: Point
                - RandomPoint: Point
                - ParticlePoint: Point
                - Point
            - Dim1 to Dim2: Existance to Length
                - Point to Line: SourcePoint to TargetPoint => PolygonEdge
            - Dim2 to Dim3: Area to Volume
                - Square to Cube
                - Circle to Sphere
                - Triange to TriPyramid
                - Rectangle to RectPyramid
            - Dim3 to Dim4: PolygonVolume projected in the 4th Dimension 
                - 4DimTesseract: 2 3DimCubes for TesseractFace 

        LevithanFace has a ParticleEngine
        LevithanFace is the IFace of a TesseractPolygon
        LevithanFace is the ILayer between 3D and 4D Shapes

        

        ParticleEngine plays ParticalApps
        GameEngine plays ParticalGames staring SolarConquestGame

        SO THIS MEANS THAT ============> LevithanGameEngine with UnityLevithanGameManager for ParticleApp in UnityApp for ParticlePlatform on PlatformNetwork

    */
}
