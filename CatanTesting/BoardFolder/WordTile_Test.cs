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
    public class WordTile_Test
    {
        WorldTile w;

        [TestMethod]
        public void ExploreTile_position_will_be_added()
        {
            w = new ExploreTile(5, 5, new Axe("Axe"), new Resource("Grain"), 9);

            Assert.AreEqual(5, w.posX);
            Assert.AreEqual(5, w.posY);
        }

        [TestMethod]
        public void ExploreTile_amount_will_be_added()
        {
           ExploreTile w = new ExploreTile(5, 5, new Axe("Axe"), new Resource("Grain"), 9);

            Assert.AreEqual(9, w.resourceAmount);
        }

        [TestMethod]
        public void ExploreTile_LootResources_will_be_true()
        {
            ExploreTile w = new ExploreTile(5, 5, new Axe("Axe"), new Resource("Grain"), 9);

            w.LootResources();

            Assert.IsTrue(w.isLooted);
        }
    }
}
