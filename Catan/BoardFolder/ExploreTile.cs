using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class ExploreTile : WorldTile
    {
        public Item Item { get; private set; }
        public Resource Resource { get; private set; }
        public int resourceAmount { get; private set; }

        public ExploreTile(int posx, int posy, Item item, Resource resource, int amount) : base( posx, posy)
        {
            Item = item;
            Resource = resource;
            resourceAmount = amount;
        }
        public ExploreTile(int posx, int posy, Resource resource, int amount) : base (posx, posy)
        {
            Resource = resource;
            resourceAmount = amount;
        }

        public void LootResources()
        {
            Item = null;
            Resource = null;
            resourceAmount = 0;
        }
    }
}
