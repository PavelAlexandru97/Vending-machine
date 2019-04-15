using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Product
    {
        public string Name { get; private set; }
        public double Price { get; private set; }
        public ProductType ProductType { get; private set; }
        public int Size { get; private set; }

        public Product(string name, double price, ProductType productType, int size)
        {
            Name = name;
            Price = price;
            ProductType = productType;
            Size = size;
        }

        public override string ToString()
        {
            var productInfo = string.Empty;
            productInfo += Name + " ";
            productInfo += Price + " ";
            productInfo += ProductType.Name + " ";
            productInfo += Size + " ";
            return productInfo;
        }
    }
}