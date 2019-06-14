using Catan;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CatanTesting
{
    [TestClass]
    public class Game_Test
    {
        Player player_Game;
        Home home_Base;
        Game g;

        private int given_Turns = 30;

        [TestInitialize]
        public void SetUp()
        {
            player_Game = new Player("Harry");
            home_Base = new Home("Home", player_Game);
            g = new Game(player_Game, given_Turns);
        }


        ////////////////////////////////////////////////////////////////
        ///                          Game Setup                      ///
        ////////////////////////////////////////////////////////////////

        /// <summary>
        /// Game will add the given player
        /// check for correct player
        /// </summary>
        [TestMethod]
        public void Game_with_correct_PlayerAdded()
        {
            Assert.AreEqual(player_Game, g.Player);
        }

        /// <summary>
        /// Game will check if enemies list is made
        /// and will check if the list contains enemies
        /// </summary>
        [TestMethod]
        public void Game_with_all_enemies_Added()
        {
            CollectionAssert.AllItemsAreInstancesOfType(g.Enemys, typeof(Enemy));
        }

        /// <summary>
        /// Game will check if enemies list is made
        /// and will check if the list contains enemies
        /// </summary>
        [TestMethod]
        public void Game_with_MapList_filled()
        {
            CollectionAssert.AllItemsAreNotNull(g.Map);
        }


        ///// <summary>
        ///// give new enemy will return null
        ///// because home has no defence
        ///// Defence must always start from one!
        ///// </summary>
        //[TestMethod]
        //public void GiveNewEnemy_noDefence_returnNull()
        //{
        //    Enemy e = g.GiveNewEnemy();

        //    Assert.AreEqual(1, e.Damage);
        //}

        /// <summary>
        /// give new enemy will return matching enemy
        /// according to Home defence
        /// </summary>
        [TestMethod]
        public void GiveNewEnemy_return_matchingEnemy()
        {
            int level_ofDefence = 10;

            g.Home.AddDefense(level_ofDefence);
            Enemy e = g.GiveNewEnemy();

            Assert.AreEqual(EnemyType.Hard, e.EnemyType);
        }

        /// <summary>
        /// Check AllResources list to see it 
        /// contains Grain
        /// </summary>
        [TestMethod]
        public void Check_allResources_List_for_Grain()
        {
            Resource r = g.AllResources.Find(x => x.Name.Contains("Grain"));
            CollectionAssert.Contains(g.AllResources, r);
        }

        /// <summary>
        /// Check AllResources list to see it 
        /// contains Iron
        /// </summary>
        [TestMethod]
        public void Check_allResources_List_for_Iron()
        {
            Resource r = g.AllResources.Find(x => x.Name.Contains("Iron"));
            CollectionAssert.Contains(g.AllResources, r);
        }

        /// <summary>
        /// Add citizens to home and take 5 grains
        /// Add citizens and lessen resources.
        /// </summary>
        [TestMethod]
        public void AddCitizens_toHome_and_LoseResources()
        {
            int added_amount_ofResources = 12;
            int new_amount_ofResources = 2;

            Resource r = g.AllResources.Find(x => x.Name.Contains("Grain"));

            player_Game.AddResources(r, added_amount_ofResources);

            g.AddCitizenToHome();

            Assert.AreEqual(player_Game.Resources[r], new_amount_ofResources);
        }

        /// <summary>
        /// Turns will deplete by one
        /// </summary>
        [TestMethod]
        public void NextTurn_Turns_decrease_by_one()
        {
            int expected_amount_ofTurnsLeft = 29;

            g.NextTurn();

            Assert.AreEqual(expected_amount_ofTurnsLeft, g.TurnsLeft);
        }

        /// <summary>
        /// Turns will give random value
        /// between one and six
        /// </summary>
        [TestMethod]
        public void NextTurn_Turns_random_value_betweenOneAndSix()
        {
            bool turns_are_withinRange = false;

            g.NextTurn();

            if (g.MovesLeft >= 1 && g.MovesLeft <= 6)
                turns_are_withinRange = true;

            Assert.IsTrue(turns_are_withinRange);
        }

        /// <summary>
        /// change position of player, add one (y)
        /// </summary>
        [TestMethod]
        public void MovePlayer_positionY_change_up()
        {
            int given_switch_number = 1;
            int expected_new_position = 6;

            g.NextTurn();
            int return_value = g.MovePlayer(given_switch_number);

            Assert.AreEqual(expected_new_position, player_Game.posY);
            Assert.AreEqual(1, return_value);
        }

        /// <summary>
        /// change position of player, take one (x)
        /// </summary>
        [TestMethod]
        public void MovePlayer_positionX_change_down()
        {
            int given_switch_number = 2;
            int expected_new_position = 4;

            g.NextTurn();
            int return_value = g.MovePlayer(given_switch_number);

            Assert.AreEqual(expected_new_position, player_Game.posX);
            Assert.AreEqual(1, return_value);
        }

        /// <summary>
        /// move player gets value outside of scope and 
        /// does not move player.
        /// </summary>
        [TestMethod]
        public void MovePlayer_default_break()
        {
            int given_switch_number = 4;
            int expected_unchanged_position = 5;

            g.MovePlayer(given_switch_number);

            Assert.AreEqual(expected_unchanged_position, player_Game.posX);
        }

        [TestMethod]
        public void CurrentTile_returns_correctMap()
        {
            int expected_x_position = 5;
            int expected_y_position = 5;

            WorldTile w = g.CurrentTile();

            Assert.AreEqual(g.Map[expected_x_position, 
                expected_y_position],
                w);
        }

      

    }
}
