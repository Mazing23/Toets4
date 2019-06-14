using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    [Serializable]
    public class Gun : Weapon
    {

        public override int Damage
        {
            get
            {
                return Name.Length + 3;
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