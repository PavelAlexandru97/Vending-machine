using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using VendingMachine.FileOperations;


namespace VendingMachine
{    
    class Program
    {
        static void Main(string[] args)
        {
            ProductCollection productCollection = new ProductCollection(5, 5);
            DataImport dataImport = new DataImport();
      
            string pathOfContainableItems= ConfigurationManager.AppSettings["pathOfContainableItems"];
            Dictionary<ContainableItem, int> containableItems = dataImport.ReadContainableItems(pathOfContainableItems);
            foreach (var item in containableItems)
            {
                productCollection.AddContainableItem(item.Key, item.Value);
            }
            Console.ReadLine();
        }
    }
}