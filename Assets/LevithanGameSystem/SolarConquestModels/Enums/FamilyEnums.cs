using SoverignParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Empire Families
Admin: Omega => Wraith Commando or Wraith Marine
Archs:
    Omega => Officer Specialist Family => Omega Quazar Family => Dathomorien => Black Wraith
    Psi => Specialist Marine Family => Psi Photon Family => Ethereal => Purple Wraith
    Theta => Commando Marine Family => Theta Proton Family => Aquarean => Cyan Wraith
    Phi => Specialist Ranger Family => Phi Electron Family => Zetan => Magenta Wraith
    Sigma => Officer Ranger Family => Sigma Neutron Family => Reptonian => Orange Wraith

Federation Families
Admin: Delta => Guardian Officer or Guardian Ranger
Archs:
    Delta => Officer Specialist Family => Delta Quazar Family => Atlantian => White Guardian
    Lambda => Specialist Marine Family => Lambda Photon Family => Terrian => Yellow Guardian
    Alpha => Commando Marine Family => Alpha Proton Family => Martian => Red Guardian
    Gamma => Specialist Ranger Family => Gamma Electron Family => Venatoan => Green Guardian
    Beta => Officer Ranger Family => Beta Neutron Family => Neptonian => Blue Guardian
*/
public enum FamilyName
{
    Admin = Particle.Delta,
    Quazar = Particle.Mu,
    Photon = Particle.Lambda,
    Electron = Particle.Gamma,
    Neutron = Particle.Beta,
    Proton = Particle.Alpha
}
