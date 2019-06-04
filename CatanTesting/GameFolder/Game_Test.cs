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
        List<Enemy> enemies_List;
        Home home_Base;
        List<Resource> resources_List;

        private int given_Turns = 30;

        [TestInitialize]
        public void SetUp()
        {
            player_Game = new Player("Harry");
            enemies_List = new List<Enemy>();
            home_Base = new Home("Home", player_Game);
            resources_List = new List<Resource>();
        }

        /// <summary>
        /// Game will fail to make and will throw
        /// certain exceptions
        /// </summary>
        /// 
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Game_Fail_with_nullValues()
        {
            Game g = new Game(null, given_Turns);
        }
        /// 
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Game_Fail_with_nullTurns()
        {
            Game g = new Game(player_Game, 0);
        }

        /// <summary>
        /// Game will add the given player
        /// check for correct player
        /// </summary>
        [TestMethod]
        public void Game_with_correct_PlayerAdded()
        {
            Game g = new Game(player_Game, given_Turns);

            Assert.AreEqual(player_Game, g.Player);
        }

        /// <summary>
        /// Game will check if enemies list is made
        /// and will check if the list contains enemies
        /// </summary>
        [TestMethod]
        public void Game_with_all_enemies_Added()
        {
            Game g = new Game(player_Game, given_Turns);

            CollectionAssert.AllItemsAreInstancesOfType(enemies_List, typeof(Enemy));
        }       

        /// <summary>
        /// give new enemy will return null
        /// because home has no defence
        /// Defence must always start from one!
        /// </summary>
        [TestMethod]
        public void GiveNewEnemy_noDefence_returnNull()
        {
            Game g = new Game(player_Game, given_Turns);
            Enemy e = g.GiveNewEnemy();

            Assert.AreEqual(null, e);
        }

        /// <summary>
        /// give new enemy will return matching enemy
        /// according to Home defence
        /// </summary>
        [TestMethod]
        public void GiveNewEnemy_return_matchingEnemy()
        {
            int level_ofDefence = 10;

            Game g = new Game(player_Game, given_Turns);
            g.Home.AddDefence(level_ofDefence);
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
            Game g = new Game(player_Game, given_Turns);
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
            Game g = new Game(player_Game, given_Turns);
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
            int added_amount_ofResources = 10;
            int new_amount_ofResources = 5;

            Game g = new Game(player_Game, given_Turns);
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

            Game g = new Game(player_Game, given_Turns);
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
            
            Game g = new Game(player_Game, given_Turns);
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
            int given_switch_number = 0;
            int expected_new_position = 6;

            Game g = new Game(player_Game, given_Turns);
            g.MovePlayer(given_switch_number);

            Assert.AreEqual(expected_new_position, player_Game.posY);
        }

        /// <summary>
        /// change position of player, take one (x)
        /// </summary>
        [TestMethod]
        public void MovePlayer_positionX_change_down()
        {
            int given_switch_number = 3;
            int expected_new_position = 4;

            Game g = new Game(player_Game, given_Turns);
            g.MovePlayer(given_switch_number);

            Assert.AreEqual(expected_new_position, player_Game.posX);
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

            Game g = new Game(player_Game, given_Turns);
            g.MovePlayer(given_switch_number);

            Assert.AreEqual(expected_unchanged_position, player_Game.posX);
        }

        [TestMethod]
        public void CurrentTile_returns_correctMap()
        {
            int expected_x_position = 5;
            int expected_y_position = 5;

            Game g = new Game(player_Game, given_Turns);
            WorldTile w = g.CurrentTile();

            Assert.AreEqual(g.Map[expected_x_position, 
                expected_y_position],
                w);
        }


    }
}
