using Catan;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CatanTesting
{
    [TestClass]
    public class Player_Test
    {
        [TestMethod]
        public void MakeNewPlayer_and_CheckHealthIsFull()
        {
            Player player = new Player("Harry");

            Assert.AreEqual(100, player.Health);
            Assert.AreEqual("Harry", player.Name);
        }

        [TestMethod]
        public void MakeWeapon_and_returnTrue()
        {
            Player player = new Player("Harry");
            Item a = new Axe("Axe");

            player.MakeItem(a);

            CollectionAssert.Contains(player.Items, a);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MakeItem_doNotAllow_nullValue_returnException()
        {
            Player player = new Player("Harry");

            player.MakeItem(null);
        }

        [TestMethod]
        public void EquipWeapon_and_returnTrue()
        {
            Player player = new Player("Harry");
            Item w = new Axe("Axe");

            player.MakeItem(w);

            bool b = player.EquipItem(w);

            Assert.IsTrue(b);
            Assert.AreEqual(w, player.EquipedWeapon);
            Assert.IsNull(player.EquipedClothes);
        }

        [TestMethod]
        public void EquipClothing_and_returnTrue()
        {
            Player player = new Player("Harry");
            Item c = new Clothing("Hennie");

            player.MakeItem(c);

            bool b = player.EquipItem(c);

            Assert.IsTrue(b);
            Assert.AreEqual(c, player.EquipedClothes);
            Assert.IsNull(player.EquipedWeapon);
        }

        [TestMethod]
        public void AddResources_to_ResourcesList()
        {
            Player player = new Player("Harry");
            Resource g = new Resource("g");
            Resource h = new Resource("h");

            player.AddResources(g, 10);

            CollectionAssert.Contains(player.Resources.Keys, g);
            CollectionAssert.DoesNotContain(player.Resources.Keys, h);
        }

        [TestMethod]
        public void AddExistingResource_amount_willChange()
        {
            Player player = new Player("Harry");
            Resource g = new Resource("g");

            player.AddResources(g, 10);
            player.AddResources(g, 35);

            Assert.AreEqual(player.Resources[g], 35);
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
