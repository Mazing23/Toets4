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
    public class Items_Test
    {
        [TestMethod]
        public void Sword_getDamage_fromLength()
        {
            Item w = new Sword("Harry");

            Assert.AreEqual(10, w.Damage);
        }

        [TestMethod]
        public void Gun_getDamage_fromLength()
        {
            Item w = new Gun("Hennie");

            Assert.AreEqual(9, w.Damage);
        }

        [TestMethod]
        public void Axe_getDamage()
        {
            Item w = new Axe("Axe");

            Assert.AreEqual(10, w.Damage);
        }

        [TestMethod]
        public void Clothing_getDamage()
        {
            Item w = new Clothing("WhatAreYouDoing");

            Assert.AreEqual(10, w.Damage);
        }
    }
}
