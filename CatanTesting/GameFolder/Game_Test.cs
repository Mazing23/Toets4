using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Catan;
using System.Collections.Generic;

namespace CatanTesting
{
    [TestClass]
    public class Game_Test
    {
        Player p;
        List<Enemy> enemies;
        Home home;
        List<Resource> resources;

        [TestInitialize]
        public void SetUp()
        {
            p = new Player("Harry");
            enemies = new List<Enemy>();
            home = new Home("Home", p);
            resources = new List<Resource>(); 
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MakeNewGameFail_with_nullValues()
        {
            Game g = new Game(null, enemies, home, 30, resources);
        }

        [TestMethod]
        public void MakeNewGame_with_PlayerAdded()
        {
            Game g = new Game(p, enemies, home, 30, resources);
            Assert.AreEqual(p, g.Player);
        }

        [TestMethod]
        public void GiveNewEnemy_CheckEnemyType()
        {
            Game g = new Game(p, enemies, home, 30, resources);
            g.SetUpGame();
            g.Home.AddDefense(10);
            Enemy e = g.GiveNewEnemy();

            Assert.AreEqual(EnemyType.Hard, e.EnemyType);
        }

        [TestMethod]
        public void AddCitizenToHome_withEnoughResources()
        {
            Game g = new Game(p, enemies, home, 30, resources);
            g.SetUpGame();

            Resource grain = new Resource("Grain");
            p.Resources.Add(grain, 10);

            g.AddCitizenToHome();

            Assert.AreEqual(5, p.Resources[grain]);
        }
    }
}
