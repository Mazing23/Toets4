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
    public class Items_Test
    {

        [TestMethod]
        public void Setup_Will_Add_Item()
        {
            Game g = new Game(new Player("Harry"), 10);
           
            CollectionAssert.Contains(g.allItems.Keys, "Glock");
        }

        [TestMethod]
        public void whatever_kind_of_test()
        {
            Game g = new Game(new Player("Harry"), 10);

            ItemFactory fact = new ItemFactory();
            var gun = fact.CreateItem<Gun>();
            g.AllItems.Add(gun);

            string name = nameof(gun);

            CollectionAssert.AllItemsAreInstancesOfType(g.AllItems, typeof(Gun));
            Assert.AreEqual("gun", name);
        }

        [TestMethod]
        public void another_one()
        {
            ItemFactory fact = new ItemFactory();
            var sword = fact.CreateItem<Sword>();
            string[] gunnames = new string[] { "Excalibur", "Glock", "Assualt Rifle"
            , "Red John", "Heaven Bringer", "Glory", "Lucy"};

            var test = new Dictionary<string, int>();

            test.Add(gunnames[0], sword.Damage);

            CollectionAssert.Contains(test.Keys, "Excalibur");
        }
    }
}
