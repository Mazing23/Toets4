using Catan;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatanTesting
{
    [TestClass]
    public class Resource_Test
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Cannot_Make_Resource_with_Null_Value()
        {
            Resource r = new Resource(null);
        }
    }
}
