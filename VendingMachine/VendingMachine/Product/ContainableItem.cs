using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class ContainableItem : Product,ICloneable
    {
        public int Row { get; private set; }
        public List <int> Columns { get; private set; }

        public ContainableItem(string name, double price, ProductType productType, int size,int row, List<int> columns):
            base(  name,  price,  productType, size)
        {
            Row = row;
            Columns = columns;
        }

        public object Clone()
        {
            ContainableItem containableItem = new ContainableItem(Name, Price, ProductType, Size, Row, Columns);
            return containableItem;
        }
    }
}
