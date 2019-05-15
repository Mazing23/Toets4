using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class Building
    {
        public int Health { get; set; }
        public int Position { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public List<Resource> Resources { get; set; }


        public Building(string name)
        {

        }

        public Building(string name, int health, int cost, int position)
        {
                
        }
    }
}
