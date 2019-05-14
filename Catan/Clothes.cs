using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class Clothing : Item
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public int DamageRes { get; set; }


        public Clothing()
        {

        }
    }
}
