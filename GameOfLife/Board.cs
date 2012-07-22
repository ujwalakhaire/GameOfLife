using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLife
{
    public class Board
    {
        private bool[,] cellData;
        private IList<IList<Cell>> cells;

        public IList<Cell> Cells
        {
            get
            {
                //Flattening list of cells.
                return cells.SelectMany(c => c).ToList();
            }
        }

        public Board(bool[,] seedData)
        {
            cellData = seedData;
            PopulateCells(seedData);
        }

        private void PopulateCells(bool[,] seedData)
        {
            cells = new List<IList<Cell>>();
            int rowCount = seedData.GetUpperBound(0);
            int columnCount = seedData.GetUpperBound(1);

            for (int rowIndex = 0; rowIndex <= rowCount; rowIndex++)
            {
                IList<Cell> rowOfCells = new List<Cell>();
                for (int columnIndex = 0; columnIndex <= columnCount; columnIndex++)
                {
                    Cell cell = new Cell(seedData[rowIndex, columnIndex], rowIndex, columnIndex);
                    rowOfCells.Add(cell);
                }
                cells.Add(rowOfCells);
            }
        }

        internal IEnumerable<IEnumerable<bool>> Show()
        {
            return cells.Select(rowOfCells => rowOfCells.Select(cell => cell.CurrentState));
        }

        public IList<Cell> NeighborsOf(Cell cell)
        {
            IList<Cell> neighbors = new List<Cell>();


            return neighbors;
        }
    }
}
