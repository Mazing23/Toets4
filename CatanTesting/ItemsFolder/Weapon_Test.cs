﻿using Catan;
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
        public void Sword_getDamage_fromLength_and_return_RandomValue()
        {
            Item w = new Sword();

            bool b = false;
            if (w.Damage >= 1 || w.Damage <= 5) b = true;

            Assert.IsTrue(b);
        }

        [TestMethod]
        public void Gun_getDamage_fromLength_and_return_RandomValue()
        {
            Item w = new Gun();

            bool b = false;
            if (w.Damage >= 5 || w.Damage <= 15) b = true;

            Assert.IsTrue(b);
        }

        [TestMethod]
        public void Axe_getDamage()
        {
            Item w = new Axe();

            Assert.AreEqual(10, w.Damage);
        }


    }
}
