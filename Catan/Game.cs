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
        public List<Enemy> Enemys { get; set; }
        public GameSave FileSave { get; set; }
        public GameSave FileLoad { get; set; }
        public List<Item> AllItems { get; set; }

        public Home Home
        {
            get => default(Home);
            set
            {
            }
        }

        public Game(Player player)
        {
            Player = player ?? throw new ArgumentNullException(nameof(player));
            Buildings = new List<Home>();
            Enemys = new List<Enemy>();
        }

        private void SetUpGame(Player player)
        {

        }

        public void AddBuilding(Home building)
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
