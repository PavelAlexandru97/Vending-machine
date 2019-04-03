namespace VendingMachine
{
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public float Price { get; private set; }
        public ProductType ProductType { get; private set; }
        public int Size { get; private set; }
        public int Quantity { get; private set; }

        public Product(int id, string name, float price, string productType, int size, int quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            ProductType = new ProductType(productType);
            Size = size;
            Quantity = quantity;
        }

        // Ca sa obtii detaliile mai natural
        public override string ToString()
        {
            var productInfo = string.Empty;
            productInfo += Id + " ";
            productInfo += Name + " ";
            productInfo += Price + " ";
            productInfo += ProductType.Name + " ";
            productInfo += Size + " ";
            productInfo += Quantity + " ";

            return productInfo;
        }
    }
}