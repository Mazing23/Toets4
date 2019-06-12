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

        public override string Name { get
            {
                return "NULL";
            }
        }

        public Clothing() : base()
        {
            
        }

       

        public override string ToString()
        {
            return base.ToString() + " , Damage: " + Damage;
        }
    }
}
