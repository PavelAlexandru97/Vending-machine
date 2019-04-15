using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class ProductCollection
    {
        private int rows;
        private int columns;
        private bool[,] vendingMachineSpace;
        private Dictionary<ContainableItem, int> containableItems = new Dictionary<ContainableItem, int>();

       public ProductCollection(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            vendingMachineSpace = new bool[rows, columns];
            InitializesVendingMachine(rows, columns);
        }

        public int Count
        {
            get { return containableItems.Count; }
        }

        public void AddContainableItem(ContainableItem containableItem, int quantity)
        {
            if (IsItSpace(containableItem))
            {
                ContainableItem containableItemClone = (ContainableItem)containableItem.Clone();
                foreach (var item in containableItem.Columns)
                {
                    vendingMachineSpace[containableItem.Row, item] = true;
                }                
                containableItems.Add(containableItemClone, quantity);
            }
        }

        public ContainableItem Remove(int row , int column)
        {
            bool isAProductInPosition = vendingMachineSpace[row, column] == true;
            if (isAProductInPosition)
            {
                ContainableItem containableItem = GetContainableItem(row, column);
                bool isItInStockAndItExist = containableItems[containableItem] > 0 && containableItem != null;
                if (isItInStockAndItExist)
                   containableItems[containableItem]--;
                return containableItem;
            }
            return null;
        }

        public ContainableItem GetContainableItem(int row, int column)
        {
            var itemsWithIds = containableItems.Where(x => (x.Key.Row == row) && (x.Key.Columns[0] == column)).ToList();
            bool isAContainableItem = itemsWithIds.Count > 0;
            if (isAContainableItem)
            {
                return itemsWithIds[0].Key;
            }

            return null;
        }

        private bool IsItSpace(ContainableItem containableItem)
        {
            bool isItOutside = (containableItem.Row < this.rows && containableItem.Row < 0 && verifyTheColumns(containableItem));

            if (isItOutside)
                foreach (var item in containableItem.Columns)
                {
                    bool isItspace = vendingMachineSpace[containableItem.Row, item] == true;
                    if (isItspace)
                        return false;
                }                          
            return true;
        }

        private bool verifyTheColumns(ContainableItem containableItem)
        {
            foreach (var item in containableItem.Columns)
            {
                bool isItOutside = item >= this.columns || item < 0;
                if (isItOutside)
                    return false;
            }
            return true;
        }

        private void InitializesVendingMachine(int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    vendingMachineSpace[i, j] = false;
                }
            }
        }
    }
}
