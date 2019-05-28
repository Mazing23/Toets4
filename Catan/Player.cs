using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class Player
    {
        public string Name { get; set; }
        public List<Item> Items { get; set; }
        public Clothing EquipedClothes { get; set; }
        public Item EquipedItem { get; set; }
        public Weapon EquipedWeapon { get; set; }
        public Dictionary<Resource, int> Resources { get; set; }
        public int Health { get; set; }
        public int Position { get; set; }
        public Home Home { get; set; }


        public Player(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Health = 100;
            Items = new List<Item>();
            Resources = new Dictionary<Resource, int>();
        }

        /// <summary>
        /// Return true if Item was able to be added. Return false if not able or if item was null.
        /// Item was given from game. 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></bool>
        public void MakeItem(Item item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            // take away from resources;
            Items.Add(item);
        }

        public bool EquipItem(Item item)
        {
            if (item == null) return false;
            foreach (Item i in Items)
            {
                if (i == item)
                {
                    if (i is Clothing)
                    {
                        EquipedClothes = i as Clothing;
                    }
                    else if (i is Weapon)
                    {
                        EquipedWeapon = i as Weapon;
                    }
                    return true;
                }
            }
            return false;
        }

        public void AttackEnemy(Enemy enemy)
        {
            if (EquipedWeapon == null) return;
            enemy.TakeDamage(EquipedWeapon);
        }

        public void AddResources(Resource resource, int amount)
        {
            if (resource == null) throw new ArgumentNullException(nameof(resource));
            if (Resources.ContainsKey(resource))
            {
                Resources[resource] = amount;
            }
            else
            {
                Resources.Add(resource, amount);
            }
        }
    }
}
