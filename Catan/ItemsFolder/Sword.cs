using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class Sword : Weapon
    {
        Random rand = new Random();

        public override int Damage { get
            {
                if (Name.Length > 50) return 50;
                if(Name.Length - 5 <= 0) return rand.Next(1, Name.Length);
                return rand.Next((Name.Length - 5), Name.Length);
            }
        }
        public Sword(string name) : base(name)
        {
            
        }

        public override Item Clone()
        {
            return new Sword(Name);
        }

        public override string ToString()
        {
            return base.ToString() + " , Damage: " + Damage;
        }

    }
}
