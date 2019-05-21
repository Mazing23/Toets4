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

        private void SetUpGame(Player player)
        {

        }

        public void AddBuilding(Building building)
        {

        }

        public void GiveNewEnemy()
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
