using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    [Serializable]
    public class Clothing : Item
    {
        public override int Damage
        {
            get
            {
                if (Name.Length - 5 <= 0) return Name.Length;
                return Name.Length - 5;
            }
        }


        public Clothing(string name) : base(name)
        {
           
        }


        public override string ToString()
        {
            return base.ToString() + " , Damage: " + Damage;
        }
    }
}