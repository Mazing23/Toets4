using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catan;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatanTesting
{
    [TestClass]
    public class Enemy_Test
    {
        [TestMethod]
        public void AddEnemy_and_CheckType()
        {
            Weapon w = new Sword("Excalibur");
            Enemy enemy = new Enemy("Harry", 100, w, 35);

            Assert.AreEqual(EnemyType.Hard, enemy.EnemyType);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddEnemyWith_nullValues_returnException()
        {
            Enemy enemy = new Enemy("Harry", 100, null, 35);
        }

        [TestMethod]
        public void ReturnDamageOfEnemy()
        {
            Weapon w = new Sword("Excalibur");
            Enemy enemy = new Enemy("Harry", 100, w, 35);

            Assert.AreEqual(35, enemy.Damage);
        }

        [TestMethod]
        public void CheckIfHealth_Matches()
        {
            Weapon w = new Sword("Excalibur");
            Enemy enemy = new Enemy("Harry", 150, w, 35);

            Assert.AreEqual(150, enemy.Health);
        }
    }
}
