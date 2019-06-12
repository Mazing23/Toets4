using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class Game
    {
        Random rand = new Random();


        public Player Player { get; private set; }
        public GameSave FileSave { get; private set; }
        public GameSave FileLoad { get; private set; }
        public Home Home { get; private set; }
        public WorldTile[,] Map { get; private set; }
        public int MovesLeft { get; private set; }
        public int TurnsLeft { get; private set; }

        
        public List<Item> AllItems { get; private set; }
        public List<Resource> AllResources { get; private set; }
        public List<Enemy> Enemys { get; private set; }

        public Dictionary<string, int> allItems { get; private set; }

        public Game(Player player, int turns)
        {
            ImplementLists();

            Player = player ?? throw new ArgumentNullException(nameof(player));
            if (turns == 0) throw new ArgumentOutOfRangeException(nameof(turns));
            TurnsLeft = turns;

            Home = new Home("Home", player);
            Map = new WorldTile[10, 10];

            Setup();
        }

        public void Setup()
        {
            string[] weaponnames = new string[] { "Excalibur", "Glock", "Assualt Rifle"
            , "Red John", "Heaven Bringer", "Glory", "Lucy"};

            ItemFactory fact = new ItemFactory();
           // var gun = fact.CreateItem<Gun>();
            var sword = fact.CreateItem<Sword>();

            //for(int i = 0; i <= weaponnames.Length; i++)
            //{
            //    var gun = fact.CreateItem<Gun>();
            //    allItems.Add(weaponnames[i], gun.Damage);
            //}
            //allItems.Add(nameof(gun), gun.Damage);


            AllResources.Add(new Resource("Wood")); // for home / defence
            AllResources.Add(new Resource("Iron")); // make weapons / clothes
            AllResources.Add(new Resource("Grain")); // for the citizens
            AllResources.Add(new Resource("Wool")); // for clothes
            AllResources.Add(new Resource("Stone")); // for home / defence

            for (int i = 1; i <= 50; i++)
            {
                int damageRandom = rand.Next(1, 51);
                Enemys.Add(new Enemy(i.ToString(), damageRandom));
            }
       
            //GenerateMap();
        }

        private void ImplementLists()
        {
            AllItems = new List<Item>();
            AllResources = new List<Resource>();
            Enemys = new List<Enemy>();
            allItems = new Dictionary<string, int>();
        }

        private void GenerateMap()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 4 && j == 4 || i == 5  && j == 4 || i == 5 && j == 4 || i == 5 && j == 5 )
                    {
                        Map[i, j] = new HomeTile(i, j);
                    }
                    else
                    {
                        if (rand.Next(1, 5) >= 3)
                        {
                            Map[i, j] = new ExploreTile(i, j, AllItems[rand.Next(1, 5)], AllResources[rand.Next(1, 5)], rand.Next(1, 5));
                        }
                        else
                        {
                            Map[i, j] = new ExploreTile(i, j, AllResources[rand.Next(1, 5)], rand.Next(1, 5));
                        }
                    }
                }
            }
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
            if (TurnsLeft >= 1)
            {
                MovesLeft = rand.Next(1, 6);
                TurnsLeft -= 1;
            }
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
        public WorldTile CurrentTile()
        {
            return Map[Player.posX, Player.posY];
        }

        public void TakeResources()
        {
            WorldTile currentTile = Map[Player.posX, Player.posY];
            if (currentTile is HomeTile)
            {
                //no actions can be taken
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
                //Map[Player.posX, Player.posY].LootResources();
            }

        }

        
    }
}
