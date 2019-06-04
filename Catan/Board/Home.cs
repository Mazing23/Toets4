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
        public string Name { get; private set; }
        public int Defence { get; set; }
        public int Citizens { get; set; }
        public Player Player { get; private set; }

        public List<Resource> Resources { get; set; }


        public Home(string name, Player player)
        {
            Player = player ?? throw new ArgumentNullException(nameof(player));
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public void AddHouse()
        {

        }

        public void AddDefense(int defense)
        {
            Defence = defense;
        }

        public void AddCitizens()
        {
            
        }

        public int CheckDefenceLevel()
        {
            if (Defence <= 5)
            {
                return 1;
            }
            if (Defence > 5 || Defence <= 10)
            {
                return 2;
            }
            if (Defence > 10)
            {
                return 3;
            }
            return 0;
        }
    }
}
