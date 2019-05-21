using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class Resource
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public int Amount { get; set; }

        public int CheckAmount()
        {
            return 1;
        }

        public Resource(string name, int value)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Value = value;
        }

        
    }
}
