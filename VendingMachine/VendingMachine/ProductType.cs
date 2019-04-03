namespace VendingMachine
{
    public class ProductType
    {
        public string Name { get; private set; }

        public ProductType(string name)
        {
            this.Name = name;
        }
    }
}
