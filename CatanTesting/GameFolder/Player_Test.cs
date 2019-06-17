using Catan;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CatanTesting
{
    [TestClass]
    public class Player_Test
    {
        Player player;

        [TestInitialize]
        public void Setup()
        {
            player = new Player("Harry");
        }

        [TestMethod]
        public void MakeNewPlayer_and_CheckHealthIsFull()
        {
            int expected_health = 100;
            string expected_name = "Harry";

            Assert.AreEqual(expected_health, player.Health);
            Assert.AreEqual(expected_name, player.Name);
        }

        [TestMethod]
        public void MakeWeapon_and_returnTrue()
        {
            Item a = new Axe("Axe");

            player.MakeItem(a);

            CollectionAssert.Contains(player.Items, a);
        }


        [TestMethod]
        public void EquipWeapon_and_returnTrue()
        {
            Item w = new Axe("Axe");

            player.MakeItem(w);

            bool result_if_item_was_available = player.EquipItem(w);

            Assert.IsTrue(result_if_item_was_available);
            Assert.AreEqual(w, player.EquipedWeapon);
            Assert.IsNull(player.EquipedClothes);
        }

        [TestMethod]
        public void EquipClothing_and_returnTrue()
        {
            Item c = new Clothing("Hennie");

            player.MakeItem(c);

            bool result_if_item_was_available = player.EquipItem(c);

            Assert.IsTrue(result_if_item_was_available);
            Assert.AreEqual(c, player.EquipedClothes);
            Assert.IsNull(player.EquipedWeapon);
        }

        [TestMethod]
        public void AddResources_to_ResourcesList()
        {
            Resource g = new Resource("g");
            Resource h = new Resource("h");

            player.AddResources(g, 10);

            CollectionAssert.Contains(player.Resources.Keys, g);
            CollectionAssert.DoesNotContain(player.Resources.Keys, h);
        }

        [TestMethod]
        public void AddExistingResource_amount_willChange()
        {
            Resource g = new Resource("g");

            player.AddResources(g, 10);
            player.AddResources(g, 25);

            Assert.AreEqual(player.Resources[g], 35);
        }

        [TestMethod]
        public void TakeDamage_lose_health()
        {
            int player_health = 90;

            player.TakeDamage(10);

            Assert.AreEqual(player_health, player.Health);
        }
        
        [TestMethod]
        public void SetHealth_returns1_if_health_is_not0()
        {
            int return_value = 1;
            int new_health = 55;

            Assert.AreEqual(return_value, player.setHealth(new_health));
        }
    }
}
