using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class Resource : ISetup
    {
        public string Name { get; set; }

        public Resource(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

    }
}
