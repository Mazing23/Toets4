using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Catan;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
