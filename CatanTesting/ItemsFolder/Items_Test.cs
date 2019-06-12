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
        //[TestMethod]
        //[ExpectedException(typeof(ArgumentNullException))]
        //public void Item_Fail_with_nullValues()
        //{
        //    //Item g = new Weapon();
        //}

        [TestMethod]
        public void Setup_Will_Add_Item()
        {
            Game g = new Game(new Player("Harry"), 10);

            //Item i = ItemFactory.Create("Glock");

            //Assert.AreEqual(null, i);
            //Assert.AreEqual("Glock", i.Name);
            //Assert.AreEqual(typeof(Gun), i.GetType());
        }

        [TestMethod]
        public void Setup_Makes_new_Item()
        {
            //Game g = new Game(new Player("Harry"), 10);

            //Item i = ItemFactory.Create("AllNieuw");

            //Assert.AreEqual("AllNieuw", i.Name);
            //Assert.AreEqual(typeof(Gun), i.GetType());
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

            g.allItems.Add(name, gun.Damage);

            CollectionAssert.Contains(g.allItems, "gun");
        }
    }
}
