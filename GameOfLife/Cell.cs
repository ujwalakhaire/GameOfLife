using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLife
{
    public class Cell
    {
        private int x;
        private int y;

        public Cell(bool state, int rowIndex, int columnIndex)
        {
            // TODO: Complete member initialization
            CurrentState = state;
            x = rowIndex;
            y = columnIndex;
        }

        public bool CurrentState { get; set; }

        public int X
        {
            get
            {
                return x;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
        }
    }
}
