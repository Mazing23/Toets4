 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
   
    public class WorldTile
    {
        public int posX { get; }
        public int posY { get; }
        public Item Item { get; private set; }
        public Resource Resource { get; private set; }
        public int resourceAmount { get; private set; }


        public WorldTile(int posx, int posy, Item item, Resource resource)
        {
            posX = posx;
            posY = posy;
            Item = item;
            Resource = resource;
        }

        public WorldTile(int posx, int posy, Resource resource)
        {
            posX = posx;
            posY = posy;
            Item = null;
            if (resource == null)
            {
                resource = null;
            }
            else
            {
                Resource = resource;
            }
        }
        public void lootResources()
        {
            Item = null;
            Resource = null;
            resourceAmount = 0;
        }
    }
}
