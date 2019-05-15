using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class Game
    {
        public Player Player { get; set; }
        public Building Building { get; set; }
        public Enemy Enemy { get; set; }
        public FileWriter FileWriter { get; set; }
        public FileReader FileReader { get; set; }


        public Game()
        {

        }

        
    }
}
