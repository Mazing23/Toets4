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
        public List<Enemy> Enemys { get; }
        public GameSave FileSave { get; }
        public GameSave FileLoad { get; }
        public List<Item> AllItems { get; }
        public List<Resource> AllResources { get; }
        public Home Home { get; }

        Random rand = new Random();


        public Game(Player player)
        {
            Player = player ?? throw new ArgumentNullException(nameof(player));
            Enemys = new List<Enemy>();
            AllItems = new List<Item>();
            AllResources = new List<Resource>();
            Home = new Home("Home", player);
        }

        private void SetUpResources()
        {
            AllResources.Add(new Resource("Wood"));
            AllResources.Add(new Resource("Iron"));
            AllResources.Add(new Resource("Grain"));
            AllResources.Add(new Resource("Wool"));
            AllResources.Add(new Resource("Stone"));
        }

        private void SetUpEnemies()
        {
            int damageRandom = rand.Next(1, 51);
            for(int i = 1; i <= 50; i++)
            {
                Enemys.Add(new Enemy(i.ToString(), 100, damageRandom));
            }
        }

        private void SetUpItems()
        {

        }

        public void SetUpGame(Player player)
        {
            SetUpResources();
            SetUpEnemies();
            SetUpItems();
        }

        public void AddDefenseToHome()
        {
            Home.AddDefense(); // do something else here
        }

        public void AddCitizenToHome()
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
