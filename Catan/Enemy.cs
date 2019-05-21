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
        public Weapon Weapon { get; set; }

        public EnemyType EnemyType
        {
            get => default(EnemyType);
            set
            {
            }
        }

        public EnemyType EnemyType1
        {
            get => default(EnemyType);
            set
            {
            }
        }

        public Enemy()
        {

        }

        public void Attack()
        {

        }
    }
}
