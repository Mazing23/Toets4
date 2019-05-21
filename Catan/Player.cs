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
        public Weapon EquipedWeapon { get; set; }
        public Dictionary<int, Resource> Resources { get; set; }
        public int Health { get; set; }
        public int Position { get; set; }

        public Home Home
        {
            get => default(Home);
            set
            {
            }
        }

        public Player(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Health = 100;
        }

        public void EquipWeapon(Weapon weapon)
        {

        }

        public void EquipClothes(Clothing clothes)
        {

        }

        public void EquipItem(Item item)
        {

        }

        public void AttackEnemy(Enemy enemy)
        {

        }

        public void AddResources(Resource resource, int amount)
        {
            //for(int i = 0; i <= amount; i++)
            //{
            //    player.Resources.Add(resource);
            //}
        }

        public void ChangeEquipedItem(Item item)
        {

        }

        public void PurchaseBuilding(Home building, Resource resource)
        {

        }
    }
}
