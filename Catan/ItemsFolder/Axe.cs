using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class Axe : Weapon
    {
        public override int Damage { get; }
        public Axe(string name, int damage) : base(name, damage)
        {

        }

    }
}
