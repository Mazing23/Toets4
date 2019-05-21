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
        public List<Resource> AllResources { get; set; }
        public Home Home { get; set; }


        public Game(Player player)
        {
            Player = player ?? throw new ArgumentNullException(nameof(player));
            Enemys = new List<Enemy>();
            AllItems = new List<Item>();
            AllResources = new List<Resource>();
        }

        private void SetUpResources()
        {

        }

        private void SetUpGame(Player player)
        {

        }

        private void AddDefenseToHome()
        {

        }

        private void AddCitizenToHome()
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
