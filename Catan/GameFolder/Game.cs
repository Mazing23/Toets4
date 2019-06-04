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
        public Dictionary<Resource, int> Resources { get; set; }
        public Home Home { get; }
        public WorldTile[,] Map;
        public int MovesLeft;
        public int TurnsLeft { get; private set; }

        Random rand = new Random();


        public Game(Player player, List<Enemy> enemys, Home home, int turns, List<Resource> resource)
        {
            Map = new WorldTile[10, 10];
            Player = player ?? throw new ArgumentNullException(nameof(player));
            Enemys = enemys ?? throw new ArgumentNullException(nameof(enemys));
            AllResources = resource ?? throw new ArgumentNullException(nameof(resource));
            Home = home ?? throw new ArgumentNullException(nameof(home));
            TurnsLeft = turns;
        }

        private void SetUpResources()
        {
            AllResources.Add(new Resource("Wood")); // for home / defence
            AllResources.Add(new Resource("Iron")); // make weapons / clothes
            AllResources.Add(new Resource("Grain")); // for the citizens
            AllResources.Add(new Resource("Wool")); // for clothes
            AllResources.Add(new Resource("Stone")); // for home / defence
        }

        private void SetUpItems()
        {
            AllItems.Add(new Sword("Wooden Sword", 5));
            AllItems.Add(new Sword("Stone Sword", 10));
            AllItems.Add(new Sword("Iron Sword", 15));
            AllItems.Add(new Gun("Pistol", 10));
            AllItems.Add(new Gun("Assault Rifle", 20));
        }

        private void GenerateMap()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 5 || i == 6 || j == 5 || j == 6)
                    {
                        Map[i, j] = new HomeTile(i, j);
                    }
                    else
                    {
                        if (rand.Next(5) == 5)
                        {
                            Map[i, j] = new ExploreTile(i, j, AllItems[rand.Next(0, 4)], AllResources[rand.Next(0, 4)], rand.Next(0, 4));
                        }
                        else
                        {
                            Map[i, j] = new ExploreTile(i, j, AllResources[rand.Next(0, 4)], rand.Next(0, 4));
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Set up  50 ENEMIES with a random damage value 
        /// between 1 and 50. 
        /// </summary>
        private void SetUpEnemies()
        {
            int damageRandom = rand.Next(1, 51);
            for (int i = 1; i <= 50; i++)
            {
                Enemys.Add(new Enemy(i.ToString(), damageRandom));
            }
        }

        public void SetUpGame()
        {
            SetUpResources();
            SetUpEnemies();
            SetUpItems();
            GenerateMap();

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
            foreach (Resource r in AllResources)
            {
                if (Player.Resources.ContainsKey(r))
                {
                    if (Player.Resources[r] >= 5)
                    {
                        Player.Resources[r] = Player.Resources[r] - 5;
                    }
                }
            }
        }

        public Enemy GiveNewEnemy()
        {
            foreach (Enemy e in Enemys)
            {
                if (Home.CheckDefenceLevel() == 1)
                {
                    if (e.EnemyType == EnemyType.Easy)
                    {
                        return e;
                    }
                }
                if (Home.CheckDefenceLevel() == 2)
                {
                    if (e.EnemyType == EnemyType.Hard)
                    {
                        return e;
                    }
                }
                if (Home.CheckDefenceLevel() == 3)
                {
                    if (e.EnemyType == EnemyType.Extreme)
                    {
                        return e;
                    }
                }
                if (Home.CheckDefenceLevel() == 0) return null;
            }
            return null;
        }

        public void SaveGame(Game gameToSave)
        {
            //Add serialization
        }

        public Game LoadGame(string gameDirectory)
        {
            Game loadGame = null;
            return loadGame;
            //Add deserialization
        }

        public void NextTurn()
        {
            MovesLeft = rand.Next(1, 6);
            TurnsLeft -= 1;
        }

        public void MovePlayer(int movements)
        {
            switch (movements)
            {
                case 0:
                    Player.posY += 1;
                    break;
                case 1:
                    Player.posY -= 1;
                    break;
                case 2:
                    Player.posX += 1;
                    break;
                case 3:
                    Player.posX -= 1;
                    break;
                default:
                    break;
            }
        }
        public WorldTile currentTile()
        {
            return Map[Player.posX, Player.posY];
        }

        public void takeResources()
        {
            WorldTile currentTile = Map[Player.posX, Player.posY];
            if (currentTile is HomeTile)
            {
                //no actions kan be taken
            }
            else if (currentTile is ExploreTile)
            {
                ExploreTile ex = currentTile as ExploreTile;
                if (ex.Resource != null || ex.resourceAmount != 0)
                {
                    Player.AddResources(ex.Resource, ex.resourceAmount);
                }
                if (ex.Item != null)
                {
                    Player.MakeItem(ex.Item);
                }
                Map[Player.posX, Player.posY].LootResources();
            }

        }
    }
}
