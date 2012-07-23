using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLife
{
    public class Cell
    {
        public Cell(bool state, int rowIndex, int columnIndex)
        {
            // TODO: Complete member initialization
            CurrentState = state;
            X = rowIndex;
            Y = columnIndex;
        }

        public Cell(int rowIndex, int columnIndex) :this(false, rowIndex, columnIndex)
        {
        }

        public Cell() : this(0,0)
        {
        }

        public Boolean CurrentState { get; set; }
        public Boolean? NextState { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return String.Format("{0} <current State: {1}, X: {2}, Y: {3}>", base.ToString(), CurrentState, X, Y); 
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Cell cell = obj as Cell;
            if (obj == null)
                return false;

            return ((cell.CurrentState == this.CurrentState) && (cell.X == this.X) && (cell.Y == this.Y));
        }
    }
}
