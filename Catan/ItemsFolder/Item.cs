using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public abstract class Item : IDamage, IClone
    {
        public string Name { get; private set; }
        public int Amount { get; set; }
        public abstract int Damage { get; }


        public Item(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public abstract Item Clone();

        public override string ToString()
        {
            return Name;
        }

    }
}
