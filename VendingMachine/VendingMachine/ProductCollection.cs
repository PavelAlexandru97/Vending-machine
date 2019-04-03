using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class ProductCollection
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(int idProduct, string name, float price, string typeOfProduct, int size, int quantity)
        {
            Product product = new Product(idProduct, name, price, typeOfProduct, size, quantity);
            products.Add(product);
        }

        public void RemoveProduct(int idProduct)
        {
            foreach (var product in products)
            {
                if (idProduct == product.IdProduct)
                {
                    products.Remove(product);
                }
            }
        }

        public int CountProducts()
        {
            int numbersOfProducts;
            numbersOfProducts = products.Count;
            return numbersOfProducts;
        }

        public Product GetProduct(int idProduct)
        {
            Product productFound = new Product(-1, "There is no product", -1, "undescribed", -1, -1);
            foreach (var product in products)
            {
                if (idProduct == product.IdProduct)
                {
                    productFound = product;
                    return productFound;
                }
            }
            return productFound;
        }

        public string DisplayProduct(Product product)
        {
            string informationOfProduct="";
            informationOfProduct += product.IdProduct + " ";
            informationOfProduct += product.Name + " ";
            informationOfProduct += product.Price + " ";
            informationOfProduct += product.TypeOfProduct.Name + " ";
            informationOfProduct += product.Size + " ";
            informationOfProduct += product.Quantity + " ";
            return informationOfProduct;
        }
    }
}
