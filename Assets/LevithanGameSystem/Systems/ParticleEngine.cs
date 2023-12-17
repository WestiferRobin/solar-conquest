﻿using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoverignParticles
{

    public class ParticleEngineComponent : EngineComponent, IParticle
    {
        public Particle EngineParticle { get; }

        public Particle ParticleID => this.EngineParticle;

        public ParticleEngineComponent(Particle engineParticle) : base(new ParticleEngine(engineParticle))
        {
            this.EngineParticle = engineParticle;
        }
    }

    public class ParticleEngine : IParticle, IEngine
    {
        public ParticleEngineComponent ParticleComponent { get; }
        public Particle ParticleID { get => ParticleComponent.ParticleID; }

        public ViewModel ModelView => throw new NotImplementedException();

        public ModelController ModelController => throw new NotImplementedException();

        public ParticleEngine(Particle pid)
        {
            //this.ParticleComponent = new EngineComponent();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void Tick()
        {
            throw new NotImplementedException();
        }

        public bool IsRunning()
        {
            throw new NotImplementedException();
        }
    }

}