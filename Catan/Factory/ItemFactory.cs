using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public static class ItemFactory
    {
        private static List<Item> standardItems;
       
        
        static ItemFactory()
        {
            standardItems = new List<Item>
            {
                new Gun("Glock"),
                new Sword("Excalibur"),
                new Gun("AssualtRifle"),
                new Sword("IronSword"),
                new Gun("Wood")
            };
        }

        public static Item Create(string name)
        {
            Item standard = standardItems.FirstOrDefault(item => item.Name == name);
            if(standard != null)
            {
                return standard.Clone(name);
            }
            return null;
        }
    }
}