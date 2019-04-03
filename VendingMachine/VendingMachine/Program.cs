using System;

namespace VendingMachine
{
    class Program
    {
        private static ProductCollection productCollection;

        static void Main(string[] args)
        {
            productCollection = new ProductCollection();
            
            AddProductMethod1();
            AddProductMethod2();

            string productInformation = productCollection.GetProductByProductId(0).ToString();
            Console.WriteLine(productInformation);
            Console.ReadLine();
        }

        private static void AddProductMethod1()
        {
            int idProduct = 0;
            string name = "ColaCoca";
            float price = 2;
            string typeOfProduct = "bottle";
            int size = 2;
            int quantity = 10;

            productCollection.AddProduct(idProduct, name, price, typeOfProduct, size, quantity);
        }

        private static void AddProductMethod2()
        {
            int idProduct = 1;
            string name = "Pepsi";
            float price = 2;
            string typeOfProduct = "bottle";
            int size = 2;
            int quantity = 9;
            Product product = new Product(idProduct, name, price, typeOfProduct, size, quantity);

            productCollection.AddProduct(product);
        }
    }
}