using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLife.IO
{
    public class InMemoryOutputFormatter : IOutputFormatter
    {
        public object Output(bool[,] data)
        {
            //Since this is in memory data, no formatting is required.
            return data;
        }
    }
}
