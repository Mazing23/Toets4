using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public abstract class Item : IDamage
    {
        public abstract string Name { get; set; }
        public int Amount { get; set; }
        public abstract int Damage { get; }

        public Item()
        {
        }

        public override string ToString()
        {
            return Name;
        }

    }
}