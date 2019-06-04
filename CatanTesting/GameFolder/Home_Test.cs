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
    public class Home_Test
    {
        Player p;
        List<Enemy> enemies;
        Home home;
        List<Resource> resources;

        [TestInitialize]
        public void SetUp()
        {
            p = new Player("Harry");
            enemies = new List<Enemy>();
            home = new Home("Home", p);
            resources = new List<Resource>();
        }


    }
}
