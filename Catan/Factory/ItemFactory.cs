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
        public T CreateItem<T>() where T : Item, new()
        {
            var obj = new T();
            return new T();
        }

    }

}