using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class Sword : Weapon
    {
        public override int Damage { get; }
        public Sword(string name, int damage) : base(name, damage)
        {

        }


    }
}
