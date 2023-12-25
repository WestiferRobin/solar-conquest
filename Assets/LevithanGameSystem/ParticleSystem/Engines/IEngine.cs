using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IEngine : IModel
{
    IApp App { get; }

    void Tick();
    void Start();
    void Stop();
    bool IsRunning();
    IApp Eject();
}
