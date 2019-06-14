using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    [Serializable]
    public class ExploreTile : WorldTile
    {
        public Item Item { get; private set; }
        public Resource Resource { get; private set; }
        public int resourceAmount { get; private set; }
        public bool isLooted { get; private set; }

        public ExploreTile(int posx, int posy, Item item, Resource resource, int amount) : base( posx, posy)
        {
            Item = item ?? throw new ArgumentNullException(nameof(item));
            Resource = resource ?? throw new ArgumentNullException(nameof(resource));
            resourceAmount = amount;
            isLooted = false;
        }
        public ExploreTile(int posx, int posy, Resource resource, int amount) : base (posx, posy)
        {
            Resource = resource ?? throw new ArgumentNullException(nameof(resource));
            resourceAmount = amount;
            isLooted = false;
        }

        public override void LootResources()
        {
            isLooted = true;
        }
    }
}
