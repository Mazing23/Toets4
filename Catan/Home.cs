using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class Home
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int Defence { get; set; }
        public int Citizens { get; set; }

        public List<Resource> Resources { get; set; }


        public Home(string name)
        {

        }

        public void AddHouse()
        {

        }

        public void AddDefense()
        {

        }

        public void AddCitizens()
        {
            throw new System.NotImplementedException();
        }
    }
}
