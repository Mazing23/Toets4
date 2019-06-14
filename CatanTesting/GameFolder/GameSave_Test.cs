using Catan;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CatanTesting
{
    [TestClass]
    public class GameSave_Test
    {
        Game g;
        GameSave gs;

        string fileNameBinairy = @"C:\PRCTOETS4\Game.txt";

        [TestInitialize]
        public void Setup()
        {
            g = new Game(new Player("pop"), 35);
            gs = new GameSave();

            var dir = @"C:\PRCTOETS4";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            if (!File.Exists(fileNameBinairy))
            {
                File.Create(fileNameBinairy);
            }
            using (Stream stream = File.Open(fileNameBinairy, FileMode.Create))
            {
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, g);
            }
        }


        [TestMethod]
        [ExpectedException(typeof(IOException))]
        public void GameSave_LoadGame()
        {
            using (Stream stream = File.Open(fileNameBinairy, FileMode.Create))
            {
                gs.LoadGame(fileNameBinairy);
                stream.Close();
            }
        }

        
    }
}
