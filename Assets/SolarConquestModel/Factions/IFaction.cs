using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public interface IFaction
    {
        Prism GetAvatar();
        
        Hedron GetAvatarHedron();

        List<Particle> GetFactionFlags();
        bool IsAlive();

        Prism GetArch();
        Prism GetArchGuardian();
        Dictionary<FamilyName, Dictionary<string, List<Family>>> GetArchFamilyRegistry();
        Dictionary<FamilyName, Dictionary<string, List<Hedron>>> GetArchArmyRegistry();

        void FactionTurn();
    }
}
