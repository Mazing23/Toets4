using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    [Serializable]
    public class Player 
    {
        public string Name { get; private set; }
        public List<Item> Items { get; set; }
        public Clothing EquipedClothes { get; private set; }
        public Weapon EquipedWeapon { get; set; }
        public Dictionary<Resource, int> Resources { get; set; }
        public int Health { get; private set; }
        public int posX { get; set; }
        public int posY { get; set; }
        public Home Home { get; private set; }


        public Player(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Health = 100;
            Items = new List<Item>();
            Resources = new Dictionary<Resource, int>();
            posX = 5;
            posY = 5;
        }


        /// <summary>
        /// Return true if Item was able to be added. Return false if not able or if item was null.
        /// Item was given from game. 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></bool>
        public void MakeItem(Item item)
        {
            // take away from resources;
            if (item == null) throw new ArgumentNullException(nameof(item));
            if (!Items.Contains(item))
            {
                Items.Add(item);
            } 
        }

        public bool EquipItem(Item item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            if(Items.Contains(item))
            {
                if (item is Clothing)
                {
                    EquipedClothes = item as Clothing;
                }
                else if (item is Weapon)
                {
                    EquipedWeapon = item as Weapon;
                    Console.WriteLine("Player equipped" + EquipedWeapon.ToString());
                }
                return true;
            }
            return false;
        }

        public void AddResources(Resource resource, int amount)
        {
            if (Resources.ContainsKey(resource))
            {
                Resources[resource] = amount;
            }
            else
            {
                Resources.Add(resource, amount);
            }
        }

        public void TakeDamage(int damageEnemy)
        {
            Health -= damageEnemy;
        }

        public int setHealth(int health)
        {
            int returnValue = 0;
            Health = health;
            if (Health > 0)
            {
                returnValue = 1; 
            }
            return returnValue;
        }
    }
}
