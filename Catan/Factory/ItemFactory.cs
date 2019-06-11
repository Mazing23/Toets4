using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class ItemFactory : ISetup
    {
        public Item Create(string name, CreateActions action)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            switch (action)
            {
                case CreateActions.Gun:
                    return new Gun(name);
                case CreateActions.Sword:
                    return new Sword(name);
                case CreateActions.Axe:
                    return new Axe(name);
                case CreateActions.Clothing:
                    return new Clothing(name);
                case CreateActions.Resource:
                    break;
            }
            return null;
        }
    }
}