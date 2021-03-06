﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    [Serializable]
    public class Game
    {
        public Player Player { get; private set; }
        public Home Home { get; private set; }
        public WorldTile[,] Map { get; private set; }
        public int MovesLeft { get; private set; }
        public int TurnsLeft { get; private set; }


        public List<Resource> AllResources { get; private set; }
        public List<Enemy> Enemys { get; private set; }
        public Dictionary<string, Item> AllItems { get; private set; }


        Random rand = new Random();

        public Game(Player player, int turns)
        {
            ImplementLists();

            Player = player ?? throw new ArgumentNullException(nameof(player));
            if (turns == 0) TurnsLeft = 1;
            TurnsLeft = turns;

            Home = new Home("Home");
            Map = new WorldTile[10, 10];

            Setup();
        }

        private void ImplementLists()
        {
            AllResources = new List<Resource>();
            Enemys = new List<Enemy>();
            AllItems = new Dictionary<string, Item>();
        }
        private void GenerateMap()
        {
            List<string> itemsInMap = new List<string>(AllItems.Keys);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if ( (i == 4 || i == 5) && (j == 4 || j == 5) )
                    {
                        Map[i, j] = new HomeTile(i, j);
                    }
                    else
                    {
                        if (rand.Next(1, 5) >= 3)
                        {
                            Map[i, j] = new ExploreTile(i, j, AllItems[itemsInMap[rand.Next(0, itemsInMap.Count -1)]], AllResources[rand.Next(1, 5)], rand.Next(1, 5));
                        }
                        else
                        {
                            Map[i, j] = new ExploreTile(i, j, AllResources[rand.Next(1, 5)], rand.Next(1, 5));
                        }
                    }
                    
                }
                
            }
        }


        public void Setup()
        {
            string[] gunnames = new string[] { "Excalibur", "Glock", "Assualt Rifle"
            , "Red John", "Heaven Bringer", "Glory", "Lucy"};
            string[] swordnames = new string[] { "Champion", "Wooden sword", "Stormbringer"
            , "Mournblade", "Sword of Dawn", "RavenBrand", "Harry"};
            string[] armournames = new string[] { "Hide Armour", "Iron Armour", "Elestial Armour"
            , "Windbreaker", "A Sheet", "A leaf", "Diamond Glades"};

            // be mindfull of the size of the arrays, as they need to be equal length
            if (gunnames.Length - swordnames.Length != 0) throw new ArgumentOutOfRangeException();
            if (gunnames.Length - armournames.Length != 0) throw new ArgumentOutOfRangeException();

            ItemFactory fact = new ItemFactory();
            for (int i = 0; i < gunnames.Length; i++)
            {
                //var gun = fact.CreateItem<Gun>();
                //allItems.Add(gunnames[i], gun);
                //allItems[gunnames[i]].Name = gunnames[i];
                ////AllItems.Add(gun);
                //var sword = fact.CreateItem<Sword>();
                //allItems.Add(swordnames[i], sword);
                //allItems[swordnames[i]].Name = swordnames[i];
                ////AllItems.Add(sword);
                //var armour = fact.CreateItem<Clothing>();
                //allItems.Add(armournames[i], armour);
                //allItems[armournames[i]].Name = armournames[i];
                ////AllItems.Add(armour);

                Item gun = new Gun(gunnames[i]);
                AllItems.Add(gun.Name, gun);
                Item sword = new Sword(swordnames[i]);
                AllItems.Add(sword.Name, sword);
                Item armour = new Clothing(armournames[i]);
                AllItems.Add(armour.Name, armour);
            }

            //var fist = fact.CreateItem<Sword>();
            Item fist = new Weapon("Fist");
            AllItems.Add("Fist", fist);

            Player.MakeItem(AllItems["Fist"]);
            Player.EquipItem(AllItems["Fist"]);

            Player.EquipItem(AllItems["Hide Armour"]);

            Console.WriteLine(Player.EquipedWeapon.ToString());

            AllResources.Add(new Resource("Wood")); // for home / defence
            AllResources.Add(new Resource("Iron")); // make weapons / clothes
            AllResources.Add(new Resource("Grain")); // for the citizens
            AllResources.Add(new Resource("Wool")); // for clothes
            AllResources.Add(new Resource("Stone")); // for home / defence

            string[] enemyList = { "Rebelious Farmer", "Giant Wolf", "Lost Knight", "Sneaky Ninja", "Slow Oger", "Swift Reeves", "Mad Scientist" };

            for (int i = 0; i < enemyList.Length; i++)
            {
                    int damageRandom = rand.Next(1, 51);
                    Enemys.Add(new Enemy(enemyList[i], damageRandom));
            }

            GenerateMap();
        }

        /// <summary>
        /// It takes 3 WOOD, 5 IRON, 2 STONE to upgrade defense
        /// </summary>
        public void AddDefenseToHome()
        {
            Resource wood = AllResources.Find(x => x.Name.Contains("Wood"));
            Resource iron = AllResources.Find(x => x.Name.Contains("Iron"));
            Resource stone = AllResources.Find(x => x.Name.Contains("Stone"));
            if(Player.Resources[wood] >= 3
                && Player.Resources[iron] >= 5
                && Player.Resources[stone] >= 2)
            {
                Home.AddDefense((Home.Defence + 2));
            }
        }

        /// <summary>
        /// It takes 5 GRAINS to add new citizens. 
        /// </summary>
        public void AddCitizenToHome()
        {
            foreach (Resource r in AllResources)
            {
                if(r == AllResources.Find(x => x.Name.Contains("Grain")))
                {
                    if (Player.Resources.ContainsKey(r))
                    {
                        if (Player.Resources[r] - 5 >= 0)
                        {
                            int i = Player.Resources[r] / 5;
                            Player.Resources[r] = Player.Resources[r] - (5 * i);
                            Home.AddCitizens(Home.Citizens + i);
                        }
                    }
                }
            }
        }

        public Enemy GiveNewEnemy()
        {
            Enemy enemyToReturn = null;
            foreach (Enemy e in Enemys)
            {
                if (Home.CheckDefenceLevel() == 1)
                {
                    if (e.EnemyType == EnemyType.Easy)
                    {
                        enemyToReturn = e;
                    }
                }
                if (Home.CheckDefenceLevel() == 2)
                {
                    if (e.EnemyType == EnemyType.Hard)
                    {
                        enemyToReturn = e; ;
                    }
                }
                if (Home.CheckDefenceLevel() == 3)
                {
                    if (e.EnemyType == EnemyType.Extreme)
                    {
                        enemyToReturn = e;
                    }
                }
            }

            if(enemyToReturn == null)
            {
                enemyToReturn = Enemys[rand.Next(0, 3)];
            }
            return enemyToReturn;
        }


        public int NextTurn()
        {
            int returnValue = 0;
            if (TurnsLeft >= 1)
            {
                MovesLeft = rand.Next(1, 6);
                TurnsLeft -= 1;
                returnValue = 1;
            }
            return returnValue;
        }

        public int MovePlayer(int movements)
        {
            int returnValue = 0;
            if (MovesLeft > 0)
            {
                switch (movements)
                {
                    case 0:
                        if(Player.posY == 0)
                        {
                            returnValue = -1;
                            break;
                        }
                        Player.posY -= 1;
                        MovesLeft -= 1;
                        returnValue = 1;
                        break;
                    case 1:
                        if (Player.posY == 9)
                        {
                            returnValue = -1;
                            break;
                        }
                        Player.posY += 1;
                        MovesLeft -= 1;
                        returnValue = 1;
                        break;
                    case 2:
                        if (Player.posX == 0)
                        {
                            returnValue = -1;
                            break;
                        }
                        Player.posX -= 1;
                        MovesLeft -= 1;
                        returnValue = 1;
                        break;
                    case 3:
                        if (Player.posX == 9)
                        {
                            returnValue = -1;
                            break;
                        }
                        Player.posX += 1;
                        MovesLeft -= 1;
                        returnValue = 1;
                        break;
                    default:
                        break;
                }
                
            }
            return returnValue;
        }
        public WorldTile CurrentTile()
        {
            return Map[Player.posX, Player.posY];
        }

        public int TakeResources()
        {
            int returnValue = 0;
            if (MovesLeft <= 0) return 0;

            WorldTile currentTile = CurrentTile();
            if (currentTile is HomeTile) return 1;

            else if (currentTile is ExploreTile)
            {
                ExploreTile ex = currentTile as ExploreTile;
                if (ex.isLooted) return 2;

                else
                {
                    if (ex.Resource != null || ex.resourceAmount != 0)
                    {
                        Player.AddResources(ex.Resource, ex.resourceAmount);
                        returnValue = 3;
                    }
                    if (ex.Item != null)
                    {
                        Player.MakeItem(ex.Item);
                        returnValue = 3;
                    }
                    Map[Player.posX, Player.posY].LootResources();
                    MovesLeft -= 1;
                    if (rand.Next(0, 5) > 2)
                    {
                        returnValue = 4;
                    }


                }


            }

            return returnValue;
        }
    }
}
