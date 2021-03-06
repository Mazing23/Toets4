﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    [Serializable]
    public class Home 
    {
        public int Health { get; private set; }
        public string Name { get; private set; }
        public int Defence { get; private set; }
        public int Citizens { get; private set; }

        public List<Resource> Resources { get; set; }


        public Home(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Defence = 1;
            Health = 100;
            Citizens = 1;
        }

        public void AddDefense(int defence)
        {
            Defence = defence;
        }

        public void AddCitizens(int amountofcitizens)
        {
            Citizens = amountofcitizens;
        }

        public int CheckDefenceLevel()
        {
            int returnvalue = 1;

            if (Defence <= 5)
            {
                returnvalue = 1;
            }
            if (Defence > 5 || Defence <= 10)
            {
                returnvalue = 2;
            }
            if (Defence > 10)
            {
                returnvalue =  3;
            }
            return returnvalue;
        }

        public void takeDamage(int damage)
        {
            Health -= damage;
        }
    }
}
