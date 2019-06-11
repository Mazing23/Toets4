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
    public class Weapon_Test
    {
        [TestMethod]
        public void Sword_getDamage_fromLength_and_return50()
        {
            Item w = new Sword("ThisIsover50CharactersLongandthusweget50backAsIsDecreed");

            Assert.AreEqual(50, w.Damage);
        }

        [TestMethod]
        public void Sword_getDamage_fromLength_and_return_RandomValue()
        {
            Item w = new Sword("Harry");

            bool b = false;
            if (w.Damage >= 1 || w.Damage <= 5) b = true;

            Assert.IsTrue(b);
        }

        [TestMethod]
        public void Gun_getDamage_fromLength_and_return20()
        {
            Item w = new Gun("ThisIsover50CharactersLongandthusweget50backAsIsDecreed");

            Assert.AreEqual(20, w.Damage);
        }

        [TestMethod]
        public void Gun_getDamage_fromLength_and_return_RandomValue()
        {
            Item w = new Gun("HarryAndNogIets");

            bool b = false;
            if (w.Damage >= 5 || w.Damage <= 15) b = true;

            Assert.IsTrue(b);
        }

        [TestMethod]
        public void Axe_getDamage()
        {
            Item w = new Axe("Harry");

            Assert.AreEqual(10, w.Damage);
        }


    }
}
