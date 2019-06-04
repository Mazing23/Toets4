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
            FileSave = new GameSave();
        }

        private void SetUpResources()
        {
            AllResources.Add(new Resource("Wood"));
            AllResources.Add(new Resource("Iron"));
            AllResources.Add(new Resource("Grain"));
            AllResources.Add(new Resource("Wool"));
            AllResources.Add(new Resource("Stone"));
        }

        /// <summary>
        /// Set up  50 ENEMIES with a random damage value 
        /// between 1 and 50. 
        /// </summary>
        private void SetUpEnemies()
        {
            int damageRandom = rand.Next(1, 51);
            for(int i = 1; i <= 50; i++)
            {
                Enemys.Add(new Enemy(i.ToString(), damageRandom));
            }
        }

        private void SetUpItems()
        {

        }

        public void SetUpGame()
        {
            SetUpResources();
            SetUpEnemies();
            SetUpItems();
        }

        /// <summary>
        /// It takes 3 WOOD, 5 IRON, 2 STONE to upgrade defense
        /// </summary>
        public void AddDefenseToHome()
        {
            //Home.AddDefense(); // do something else here
        }

        /// <summary>
        /// It takes 5 GRAINS to add new citizens. 
        /// </summary>
        public void AddCitizenToHome()
        {
            foreach(Resource r in AllResources)
            {
                if(Player.Resources.ContainsKey(r))
                {
                    if(Player.Resources[r] >= 5)
                    {
                        Player.Resources[r] = Player.Resources[r] - 5;
                        Home.Citizens += 4;
                    }
                }
            }
        }

        public Enemy GiveNewEnemy()
        {
            foreach(Enemy e in Enemys)
            {
                if(Home.CheckDefenseLevel() == 1)
                {
                    if(e.EnemyType == EnemyType.Easy)
                    {
                        return e;
                    }
                }
                if(Home.CheckDefenseLevel() == 2)
                {
                    if (e.EnemyType == EnemyType.Hard)
                    {
                        return e;
                    }
                }
                if(Home.CheckDefenseLevel() == 3)
                {
                    if(e.EnemyType == EnemyType.Extreme)
                    {
                        return e;
                    }
                }
                if (Home.CheckDefenseLevel() == 0) return null;
            }
            return null;
        }

        public void SaveGame()
        {

        }

        public void LoadGame()
        {

        }
    }
}
