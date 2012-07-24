using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLife.IO
{
    public class ConsoleOutputFormatter : IOutputFormatter
    {
        public object Output(IEnumerable<IEnumerable<bool>> data)
        {
            int rowCount = data.Count();
            int columnCount = data.First().Count();
            bool[,] output = new bool[rowCount, columnCount];

            for (int rowIndex = 0; rowIndex < rowCount; rowIndex++)
            {
                IEnumerable<bool> rowOfCellStates = data.ElementAt(rowIndex);
                for (int columnIndex = 0; columnIndex < columnCount; columnIndex++)
                {
                    output[rowIndex, columnIndex] = rowOfCellStates.ElementAt(columnIndex);
                    Console.Write("{0} ", output[rowIndex, columnIndex]? "X" : "-" );
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            return output;
        }
    }
}
