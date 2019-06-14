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
        Enemy enemy;

        [TestInitialize]
        public void SetUp()
        {
            enemy = new Enemy("Harry", 35);
        }

        [TestMethod]
        public void AddEnemy_and_CheckType()
        {
            Assert.AreEqual(EnemyType.Hard, enemy.EnemyType);
        }

        [TestMethod]
        public void ReturnDamageOfEnemy()
        {
            Assert.AreEqual(35, enemy.Damage);
        }

        [TestMethod]
        public void CheckIfHealth_Matches()
        {
            Assert.AreEqual(100, enemy.Health);
        }


        [TestMethod]
        public void TakeDamage_ReduceHealth_with_10Damage()
        {
            enemy.TakeDamage(10);           

            Assert.AreEqual(90, enemy.Health);

        }
        
    }
}
