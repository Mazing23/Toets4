using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class Clothing : Item
    {
        public int DamageRes { get; set; }

        public Clothing(string name) : base(name)
        {

        }
    }
}
