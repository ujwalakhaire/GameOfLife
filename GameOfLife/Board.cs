using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLife
{
    public class Board
    {
        private bool[,] cellData;
        private IList<Cell> cells;

        public IList<Cell> Cells
        {
            get
            {
                return cells;
            }
        }

        public Board(bool[,] seedData)
        {
            cellData = seedData;
            PopulateCells(seedData);
        }

        private void PopulateCells(bool[,] seedData)
        {
            cells = new List<Cell>();

            int rowCount = seedData.GetUpperBound(0);
            int columnCount = seedData.GetUpperBound(1);

            for (int rowIndex = 0; rowIndex <= rowCount; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex <= columnCount; columnIndex++)
                    cells.Add(new Cell(seedData[rowIndex, columnIndex], rowIndex, columnIndex));
            }
        }

        internal bool[,] Show()
        {
            return cellData;
        }
    }
}
