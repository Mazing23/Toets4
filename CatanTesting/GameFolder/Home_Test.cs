using Catan;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatanTesting
{
    [TestClass]
    public class Home_Test
    {
        Player p;
        Home h;

        [TestInitialize]
        public void SetUp()
        {
            p = new Player("Harry");
            h = new Home("Home");
        }

        [TestMethod]
        public void Health_will_be_full()
        {
            int expected_health = 100;

            Assert.AreEqual(expected_health, h.Health);
        }

        [TestMethod]
        public void Defence_will_be_one()
        {
            int expected_defence = 1;

            Assert.AreEqual(expected_defence, h.Defence);
        }

        [TestMethod]
        public void Citizens_will_be_one()
        {
            int expected_citizens = 1;

            Assert.AreEqual(expected_citizens, h.Citizens);
        }

        [TestMethod]
        public void Citizens_will_be_updated()
        {
            int expected_citizens = 4;

            h.AddCitizens(4);

            Assert.AreEqual(expected_citizens, h.Citizens);
        }

        [TestMethod]
        public void Defence_will_be_updated()
        {
            int expected_defence = 4;

            h.AddDefense(4);

            Assert.AreEqual(expected_defence, h.Defence);
        }

        [TestMethod]
        public void TakeDamage_will_decrease_health()
        {
            int expected_health = 90;
            int given_damage = 10;

            h.takeDamage(given_damage);

            Assert.AreEqual(expected_health, h.Health);
        }

        [TestMethod]
        public void AddDefence_will_update_Defence()
        {
            int current_defence = h.Defence;

            h.AddDefense(2);

            int new_defence = h.Defence;

            Assert.AreNotEqual(new_defence, current_defence);
        }

        [TestMethod]
        public void CheckDefenceLevel_return1_ifLevelIs1()
        {
            // this test can kill me and i will have been slayed by a great beast.
            Home home = new Home("Home");
            int defence_level = 0;

            if (home.Defence == 1)
                defence_level = home.CheckDefenceLevel();

            Assert.AreEqual(1, defence_level);
        }



    }
}
