using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class TypeOfProduct
    {
        public string Name { get; private set; }

        public TypeOfProduct(string name)
        {
            this.Name = name;
        }
    }
}
