using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLife.IO
{
    public class InMemoryInputFormatter : IInputFormatter
    {
        private bool[,] data;

        public InMemoryInputFormatter(bool[,] data)
        {
            this.data = data;
        }

        public bool[,] Format()
        {
            return data;
        }

        public void Display()
        {
            int rowCount = data.GetUpperBound(0);
            int columnCount = data.GetUpperBound(1);

            for (int rowIndex = 0; rowIndex <= rowCount; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex <= columnCount; columnIndex++)
                    Console.Write("{0} ", data[rowIndex, columnIndex] ? "X" : "-");

                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
