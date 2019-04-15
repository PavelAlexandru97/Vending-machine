using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.FileOperations
{
    class DataImport
    {
        private InputFile iFile = new InputFile();
        private List<List<string>> sheetOfContainableItems = new List<List<string>>();

        public Dictionary<ContainableItem,int> ReadContainableItems(string filePath)
        {
            sheetOfContainableItems = iFile.ReadFile(filePath, 7);
            Dictionary<ContainableItem, int> containableItems = new Dictionary<ContainableItem, int>();
            foreach (List<string> inf in sheetOfContainableItems)
            {
                    string name = inf[0];
                    double price = Convert.ToDouble(inf[1]);
                    ProductType productType = new ProductType(inf[2]);
                    int size = Convert.ToInt32(inf[3]);
                    int row = Convert.ToInt32(inf[4]);
                    List<int> columns = ConvertToList(inf[5]);
                    int quantity = Convert.ToInt32(inf[6]);

                ContainableItem containableItem = new ContainableItem(name, price, productType, size, row, columns);
                containableItems.Add(containableItem, quantity);
          
            }
            return containableItems;
        }

        private List<int> ConvertToList(string stringList)
        {
            string[] valueOfStringList;
            List<int> list = new List<int>();
            valueOfStringList = stringList.Split(' ');
            foreach (var item in valueOfStringList)
            {
                list.Add(Convert.ToInt32(item));
            }
            return list;
        }
    }
}
