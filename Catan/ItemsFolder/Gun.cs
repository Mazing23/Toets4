using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class Gun : Weapon
    {
        Random rand = new Random();

        public override int Damage
        {
            get
            {
                return Name.Length;
            }
        }



        public Gun(string name) : base(name)
        {
        }

        public override string ToString()
        {
            return base.ToString() + " , Damage: " + Damage;
        }


    }
}