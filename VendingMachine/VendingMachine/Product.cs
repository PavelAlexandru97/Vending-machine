using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Product
    {
        public int IdProduct { get; private set; }
        public string Name { get; private set; }
        public float Price { get; private set; }
        public TypeOfProduct TypeOfProduct { get; private set; }
        public int Size { get; private set; }
        public int Quantity { get; private set; }

        public Product(int idProduct, string name, float price, string typeOfProduct, int size, int quantity)
        {
            this.IdProduct = idProduct;
            this.Name = name;
            this.Price = price;
            this.TypeOfProduct = new TypeOfProduct(typeOfProduct);
            this.Size = size;
            this.Quantity = quantity;
        }
    }
}