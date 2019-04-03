using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductCollection productCollection = new ProductCollection();
            int idProduct = 0;
            string name = "ColaCoca";
            float price = 2;
            string typeOfProduct = "bottle";
            int size = 2;
            int quantity = 10;

            productCollection.AddProduct(idProduct, name, price, typeOfProduct, size, quantity);
            string informationOfProduct = productCollection.DisplayProduct(productCollection.GetProduct(idProduct));
            Console.WriteLine(informationOfProduct);
            Console.ReadLine();
        }
    }
}