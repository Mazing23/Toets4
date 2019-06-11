using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public abstract class Item : IDamage
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public abstract int Damage { get; }

        public Item(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
