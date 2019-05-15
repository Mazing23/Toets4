using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class Weapon : Item, IDamage
    {
        public int Damage { get; }

        public int Range { get; set; }

        public Weapon()
        {

        }
    }
}
