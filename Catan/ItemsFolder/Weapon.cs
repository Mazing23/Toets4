using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class Weapon : Item, ISetup
    {

        public int Range { get; set; }
        public override int Damage { get; }

        public Weapon(string name) : base(name)
        {
           
        }

        

        public override string ToString()
        {
            return base.ToString() + " , Damage: " + Damage;
        }

    }
}
