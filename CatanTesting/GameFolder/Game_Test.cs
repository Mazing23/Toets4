using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Catan;


namespace CatanTesting
{
    [TestClass]
    public class Game_Test
    {


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MakeNewGameFail_with_nullValues()
        {
            Game g = new Game(null);
        }

        [TestMethod]
        public void MakeNewGame_with_PlayerAdded()
        {
            Player p = new Player("Harry");

            Game g = new Game(p);

            Assert.AreEqual(p, g.Player);
        }

        [TestMethod]
        public void GiveNewEnemy_CheckEnemyType()
        {
            Player p = new Player("Harry");
            Game g = new Game(p);
            g.SetUpGame();

            g.Home.AddDefense(10);
            Enemy e = g.GiveNewEnemy();

            Assert.AreEqual(EnemyType.Hard, e.EnemyType);
        }

        [TestMethod]
        public void AddCitizenToHome_withEnoughResources()
        {
            Player p = new Player("Harry");
            Game g = new Game(p);
            g.SetUpGame();

            Resource grain = new Resource("Grain");
            p.Resources.Add(grain, 10);

            g.AddCitizenToHome();

            Assert.AreEqual(5, p.Resources[grain]);
        }
    }
}
