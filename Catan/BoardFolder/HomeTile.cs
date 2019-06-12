using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class HomeTile : WorldTile
    {
        public HomeTile(int posx, int posy) :base (posx, posy)
        {

        }
        public override void LootResources()
        {
            throw new NotImplementedException();
        }
    }
}
