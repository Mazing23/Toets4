using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class Game
    {
        public Player Player { get; }
        public List<Building> Buildings { get; set; }
        public List<Enemy> Enemys { get; set; }
        public FileWriter FileWriter { get; set; }
        public FileReader FileReader { get; set; }


        public Game(Player player)
        {
            Player = player ?? throw new ArgumentNullException(nameof(player));
            Buildings = new List<Building>();
            Enemys = new List<Enemy>();
        }

        public void AddBuilding(Player player, Building building)
        {

        }

        public void AttackEnemy(Player player, Enemy enemy)
        {

        }

        public void AddResources(Player player, Resource resource, int amount)
        {
            //for(int i = 0; i <= amount; i++)
            //{
            //    player.Resources.Add(resource);
            //}
        }

        public void ChangeEquipedItem(Player player, Item item)
        {

        }

        public void SaveGame()
        {

        }

        public void LoadGame()
        {

        }
    }
}
