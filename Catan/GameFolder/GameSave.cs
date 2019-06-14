using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Catan
{
    [Serializable]
    public class GameSave
    {
        public GameSave()
        {
            
        }

        public void SaveGame(Game game)
        {
            string fileName = @"C:\Users\Gebruiker\Desktop\gamesave.txt";
            using (Stream stream = File.Open(fileName, FileMode.Create))
            {
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, this);
            }
        }

        public Game LoadGame()
        {
            Game g = null;
            string fileName = @"C:\Users\Gebruiker\Desktop\gamesave.txt";
            using (FileStream stream = new FileStream(fileName, FileMode.Open))
            {
                BinaryFormatter bin = new BinaryFormatter();
                g = bin.Deserialize(stream) as Game;
            }
            return g;
        }
    }
}