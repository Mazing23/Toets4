using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class Axe : Weapon
    {
        public override int Damage { get
            {
                return 10;
            }
        }

        public Axe(string name) : base(name)
        {

        }

        public override string ToString()
        {
            return base.ToString() + " , Damage: " + Damage;
        }

    }
}
