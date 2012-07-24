using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace GameOfLife.IO
{
    class FileInputter : IInputFormatter
    {
        private IList<string> rows;
        string[] fileLines;

        public FileInputter(string filePath)
        {
            fileLines = File.ReadAllLines(filePath);
            rows = fileLines.Select(line => line.ToLower().Replace(" ", string.Empty)).ToList();
        }

        public bool[,] Format()
        {
            int columnCount = rows.OrderByDescending(list => list.Length).First().Count();
            int rowCount = rows.Count;
            bool[,] data = new bool[rowCount, columnCount];

            int rowIndex = 0;
            foreach (string cellLine in rows)
            {
                for (int columnIndex = 0; columnIndex < cellLine.Count(); columnIndex++)
                    data[rowIndex, columnIndex] = cellLine[columnIndex] == 'x';

                rowIndex++;
            }

            return data;
        }

        public void Display()
        {
            foreach (string line in fileLines)
                Console.WriteLine("{0}", line);

            Console.WriteLine();
        }
    }
}
