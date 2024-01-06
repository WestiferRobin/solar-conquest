using SolarConquestGameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquestUnitTests.SolarConquestUnitTests.BattleTests.LandBattle
{
    internal class PrismSquadronTests
    {
        private IPrism Avatar;
        private ISquadron Squadron;

        [SetUp]
        public void Setup()
        {
            var example = new WesPlayer();
            this.Avatar = new FederationPrism(example.Avatar.ID);
            var hedron = new ParticleHedron(this.Avatar.Hid, example.AvatarHedron.Registry);
            this.Squadron = new FederationSquadron(hedron);
        }

        [Test]
        public void HappyPath()
        {
            try
            {
                ISquadron enemy = new EmpireSquadron();
                this.Squadron.Battle(enemy);

            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
