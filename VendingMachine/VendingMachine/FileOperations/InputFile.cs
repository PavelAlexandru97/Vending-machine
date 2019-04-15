using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VendingMachine.FileOperations
{
    class InputFile
    {
        public List<List < string > > ReadFile(string path, int numberOfColumns)
            {
            List<List<string>> theFile = new List<List<string>>();

            using (var reader = new StreamReader(@path))
            {
                int rowNumber = 1;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    if (rowNumber++ == 1)
                        continue;
                    theFile.Add(ReadLine(line, numberOfColumns));
                }
            }
            return theFile;
        }

        List<string> ReadLine(string line, int numberOfColumns)
        {
            List<string> theRow = new List<string>();
            var values = line.Split(',');
            for (int i = 0; i < numberOfColumns; i++)
            {
                theRow.Add(values[i]);
            }
            return theRow;
        }
    }
}
