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
    public class Exception_testing
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Game_Fail_with_nullValues()
        {
            Game h = new Game(null, 35);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Home_throws_exeption_null_values()
        {
            Home h = new Home(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExploreTile_throws_exeption_null_values()
        {
            WorldTile h = new ExploreTile(5, 5, null, null, 9);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExploreTile_throws_exeption_null_values_second_constructor()
        {
            WorldTile h = new ExploreTile(5, 5, null, 9);
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void HomeTile_throws_expetion_when_method_is_used()
        {
            HomeTile h = new HomeTile(9, 9);
            h.LootResources();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Item_throws_exeption_null_valuesr()
        {
            Item item = new Weapon(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GameSave_throws_exception_save()
        {
            GameSave gs = new GameSave();
            gs.SaveGame(null, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GameSave_throws_exception_load()
        {
            GameSave gs = new GameSave();
            gs.LoadGame(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Resource_throws_null_exception()
        {
            Resource r = new Resource(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Player_throws_null_exception()
        {
            Player p = new Player(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MakeItem_doNotAllow_nullValue_returnException()
        {
            Player player = new Player("Harry");

            player.MakeItem(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EquipItem_doNotAllow_nullValue_returnException()
        {
            Player player = new Player("Harry");

            player.EquipItem(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddResources_withNullValue_returnException()
        {
            Player player = new Player("Harry");

            player.AddResources(null, 10);
        }
    }
}
