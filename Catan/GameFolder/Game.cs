﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class Game
    {
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

        Random rand = new Random();

        public Game(Player player, int turns)
        {
            ImplementLists();

            Player = player ?? throw new ArgumentNullException(nameof(player));
            if (turns == 0) throw new ArgumentOutOfRangeException(nameof(turns));
            TurnsLeft = turns;

            Home = new Home("Home", player);
            Map = new WorldTile[10, 10];

            SetUpGame();
        }

        private void ImplementLists()
        {
            AllItems = new List<Item>();
            AllResources = new List<Resource>();
            Enemys = new List<Enemy>();
        }
        private void GenerateMap()
        {
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


        private  void SetUpGame()
        {
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

            AllItems.Add(new Sword("Wooden Sword"));
            AllItems.Add(new Sword("Stone Sword"));
            AllItems.Add(new Sword("Iron Sword"));
            AllItems.Add(new Gun("Pistol"));
            AllItems.Add(new Gun("Assault Rifle"));

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
          if(MovesLeft > 0)
            {
                WorldTile currentTile = Map[Player.posX, Player.posY];
                if (currentTile is HomeTile)
                {
                    returnValue = 1;
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
                    MovesLeft -= 1;
                    return returnValue = 2;
                }
            }
            return returnValue;
        }
    }
}
