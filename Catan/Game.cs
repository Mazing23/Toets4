using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class Game
    {

        public Game()
        {

        }

        public Player Player
        {
            get => default(Player);
            set
            {
            }
        }

        public Building Building
        {
            get => default(Building);
            set
            {
            }
        }

        public Enemy Enemy
        {
            get => default(Enemy);
            set
            {
            }
        }

        public FileWriter FileWriter
        {
            get => default(FileWriter);
            set
            {
            }
        }

        public FileReader FileReader
        {
            get => default(FileReader);
            set
            {
            }
        }
    }
}
