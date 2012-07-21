using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLife
{
    class Board
    {
        bool[,] cellData;

        public Board(bool[,] seedData)
        {
            cellData = seedData;
        }

        internal bool[,] Show()
        {
            return cellData;
        }
    }
}
