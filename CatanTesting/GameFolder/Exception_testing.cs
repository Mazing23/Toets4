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
        /// <summary>
        /// Game will fail to make and will throw
        /// certain exceptions
        /// </summary>
        /// 
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Game_Fail_with_nullValues()
        {
            Game h = new Game(null, 35);
        }
        /// 
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Game_Fail_with_nullTurns()
        {
            Game h = new Game(new Player("Harry"), 0);
        }
    }
}
