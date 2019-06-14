using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    [Serializable]
    public class Sword : Weapon
    {
        Random rand = new Random();

        public override int Damage
        {
            get
            {
                return Name.Length;
            }
        }


        public Sword(string name) : base(name)
        {
        }

        public override string ToString()
        {
            return base.ToString() + " , Damage: " + Damage;
        }

    }
}