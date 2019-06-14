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
            h = new Home("Home", p);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Home_throws_exeption_null_values()
        {
            Home h = new Home(null, p);
            Home y = new Home("Home", null);
        }

        [TestMethod]
        public void Home_created_new_home_test_player()
        {
            Assert.AreEqual(p, h.Player);
        }

        [TestMethod]
        public void AddDefence_defence_will_change()
        {
            int new_defence = 5;
            int expected_defence = 5;

            h.AddDefense(new_defence);

            Assert.AreEqual(expected_defence, h.Defence);
        }

        [TestMethod]
        public void CheckDefenceLevel_level_willbe_one()
        {
            int new_defence = 5;
            int expected_level = 1;

            Home h = new Home("Home", p);

            h.AddDefense(new_defence);

            Assert.AreEqual(expected_level, h.CheckDefenceLevel());
        }

        [TestMethod]

        public void AddCitizens_to_home_from_Game()
        {
            Player p = new Player("h");
            Game g = new Game(p, 35);
            Resource r = g.AllResources.Find(x => x.Name.Contains("Grain"));

            p.AddResources(r, 23);

            g.AddCitizenToHome();
            //h.AddCitizens(5);

            Assert.AreEqual(5, h.Citizens);
            Assert.AreEqual(p.Resources[r], 3);
        }


        
    }
}
