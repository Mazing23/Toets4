 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    [Serializable]
    public abstract class WorldTile
    {
        public int posX { get; }
        public int posY { get; }
  


        public WorldTile(int posx, int posy)
        {
            posX = posx;
            posY = posy;
        }
       public abstract void LootResources();
    }
}
