using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public EnemyType EnemyType { get; set; }

        public Enemy(string name, int health, int damage)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Health = health;
            if (damage == 0) throw new ArgumentOutOfRangeException(nameof(damage));
            Damage = damage;

            if(damage <= 25)
            {
                EnemyType = EnemyType.Easy;
            }
            if(damage > 25 || damage <= 40)
            {
                EnemyType = EnemyType.Hard;
            }
            else if (damage > 40 || damage <= 50)
            {
                EnemyType = EnemyType.Extreme;
            }
        }
    }
}
