using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class Clothing : Item
    {
        public override int Damage { get; }

        public Clothing(string name) : base(name)
        {
            
        }

        public override Item Clone(string name)
        {
            return new Clothing(name);
        }

        public override string ToString()
        {
            return base.ToString() + " , Damage: " + Damage;
        }
    }
}
