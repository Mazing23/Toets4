using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class ItemFactory
    {
        public T CreateItem<T>() where T: Item, new()
        {
            return new T();
        }

        public IClone GetItem(ItemType type, string name)
        {
            switch (type)
            {
                case ItemType.Sword:
                    return new Sword(name);
                case ItemType.Axe:
                    return new Axe(name);
                case ItemType.Gun:
                    return new Gun(name);
                default:
                    throw new NotSupportedException();
            }
        }

        
    }

}