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

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Home_throws_exeption_null_values()
        {
            Home h = new Home(null, new Player("H"));
            Home y = new Home("Home", null);
        }

    }
}
