using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class Weapon : Item, IDamage
    {
        public virtual int Damage { get; }

        public int Range { get; set; }

        public Weapon(string name, int damage) : base(name)
        {
            Damage = damage;
        }

        public override string ToString()
        {
            return base.ToString() + " , Damage: " + Damage;
        }
    }
}
