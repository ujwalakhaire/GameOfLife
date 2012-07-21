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
    }
}
