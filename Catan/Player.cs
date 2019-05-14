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
        public Item EquipedItem { get; set; }
        public List<Clothing> Clothes { get; set; }
        public Clothing EquipedClothes { get; set; }
        public int Health { get; set; }
        public int Position { get; set; }
        public int Money { get; set; }

        public Player()
        {

        }
    }
}
