using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UnityEditor.Profiling.HierarchyFrameDataView;

namespace SolarConquestGameModels
{
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
    public interface IFace { }
    public class LevithanFace: IFace
    {
        public IComponent FaceComponent { get; set; }
        public EngineComponent Engine {  get; set; }

        public LevithanFace() { }
    }

    public class FaceModel : IComponentModel
    {
        public ViewModel ModelView => throw new NotImplementedException();

        public ModelController ModelController => throw new NotImplementedException();

        public FaceModel() { }
    }

    public class FaceView : IComponentView
    {
        public List<ViewModel> ViewModels => throw new NotImplementedException();

        public List<ViewController> ViewControllers => throw new NotImplementedException();

        public ViewModel ModelView => throw new NotImplementedException();

        public ViewModel GetViewModel()
        {
            throw new NotImplementedException();
        }

        public FaceView() { }
    }

    public class FaceController: IComponentController
    {
        public FaceController() { }

        public ModelController ModelController => throw new NotImplementedException();
    }

    public interface IFaceComponent : IComponent, IFace
    {
        public FaceModel Face { get; }

        public FaceView View { get; set; }

        public FaceController Controller { get; set; }
    }

    public class ParticleFaceComponent: IFaceComponent
    {
        public ParticleFaceComponent(Particle pid) { }

        public FaceModel Face => throw new NotImplementedException();

        public FaceView View { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public FaceController Controller { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IComponentModel ComponentModel => throw new NotImplementedException();

        public IComponentView ComponentView => throw new NotImplementedException();

        public IComponentController ComponentController => throw new NotImplementedException();
    }

    public class ParticleFace: IParticle, IFace
    {
        public IComponent Component { get; }
        public ParticleFace(Particle pid) { 
            ParticleID = pid;
            this.Component = new ParticleFaceComponent(pid);
        }

        public Particle ParticleID { get; }
    }

    public class LevithanFaceComponent: ParticleFace
    {
        public LevithanFaceComponent(): base(Particle.Omega) { }
    }
}
