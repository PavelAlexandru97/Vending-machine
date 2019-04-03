using System.Collections.Generic;

namespace VendingMachine
{
    class ProductCollection
    {
        private List<Product> products = new List<Product>();

        public int Count
        {
            get { return products.Count; }
        }

        // Metoda asta face mai mult decat spune numele, poate ar trebui sa se numeasca 'GenerateAndAddProduct'
        public void AddProduct(int productId, string name, float price, string productType, int size, int quantity)
        {
            Product product = new Product(productId, name, price, productType, size, quantity);
            products.Add(product);
        }

        // Varianta mai logica
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void RemoveProductByProductId(int productId)
        {
            foreach (var product in products)
            {
                if (productId == product.Id)
                {
                    products.Remove(product);
                }
            }
        }

        public Product GetProductByProductId(int idProduct)
        {
            foreach (var product in products)
            {
                if (idProduct == product.Id)
                {
                    return product;
                }
            }

            return null;
        }

        // Nu e responsabilitatea colectiei sa iti dea detalii despre un produs, ci responsabilitatea produsului in sine
        // Nu-si are locul aici, eventual poti face override pe metoda ToString() de la Product (uite-te in clasa Product)
        /*
        public string DisplayProduct(Product product)
        {
            var productInfo = string.Empty;
            productInfo += product.Id + " ";
            productInfo += product.Name + " ";
            productInfo += product.Price + " ";
            productInfo += product.ProductType.Name + " ";
            productInfo += product.Size + " ";
            productInfo += product.Quantity + " ";

            return productInfo;
        }
        */
    }
}
