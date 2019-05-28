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
            Enemy enemy = new Enemy("Harry", 35);

            Assert.AreEqual(EnemyType.Hard, enemy.EnemyType);
        }


        [TestMethod]
        public void ReturnDamageOfEnemy()
        {
            Enemy enemy = new Enemy("Harry", 35);

            Assert.AreEqual(35, enemy.Damage);
        }

        [TestMethod]
        public void CheckIfHealth_Matches()
        {
            Enemy enemy = new Enemy("Harry", 35);

            Assert.AreEqual(100, enemy.Health);
        }

        [TestMethod]
        public void GetDamage_ReduceHealthEnemy()
        {
            Enemy enemy = new Enemy("Harry", 20);
            Player p = new Player("Harry2");
            Item w = new Sword("poep", 20);
            p.EquipItem(w);

            p.AttackEnemy(enemy);

            Assert.AreEqual(80, enemy.Health);
        }
    }
}
