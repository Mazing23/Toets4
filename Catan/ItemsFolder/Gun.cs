using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class Gun : Weapon, ISetup
    {
        Random rand = new Random();

        public override int Damage { get
            {
                if (Name.Length > 50) return 20;
                if(Name.Length - 10 <= 0) return rand.Next(1, Name.Length);
                return rand.Next((Name.Length - 10), Name.Length); 
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
