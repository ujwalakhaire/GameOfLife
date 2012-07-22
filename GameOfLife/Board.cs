using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace GameOfLife
{
    public class Board
    {
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

            for (int rowIndex = cell.X - 1; rowIndex <= cell.X + 1; rowIndex++)
            {
                IList<Cell> rowOfCells = cells.ElementAtOrDefault(rowIndex);
                if (rowOfCells != null)
                {
                    for (int columnIndex = cell.Y - 1; columnIndex <= cell.Y + 1; columnIndex++)
                    {
                        if (rowIndex == cell.X && columnIndex == cell.Y)
                            continue;

                        Cell neighboringCell = rowOfCells.ElementAtOrDefault(columnIndex);
                        if (neighboringCell != null)
                            neighbors.Add(neighboringCell);
                    }
                }
            }

            return neighbors;
        }

        internal void ChangeToNextGeneration()
        {
            foreach (Cell cell in Cells)
            {
                cell.CurrentState = Convert.ToBoolean(cell.NextState);
                cell.NextState = null;
            }
        }

        // TODO : Write desccription
        internal void PrepareForNextGeneration()
        {
            AddDeadCellsAroundTheBoard();
            RecalculatePositions();
        }

        private void RecalculatePositions()
        {
            
        }

        private void AddDeadCellsAroundTheBoard()
        {
            int columnCount = cells.First().Count;
            IList<Cell> deadCellsRowToAdd = new List<Cell>();
            for (int index = 0; index < columnCount; index++)
                deadCellsRowToAdd.Add(new Cell());

            cells.Add(deadCellsRowToAdd);
            cells.Insert(0, new List<Cell>(deadCellsRowToAdd));

            IList<IList<Cell>> newCells = new List<IList<Cell>>();
            foreach (IList<Cell> rowOfCells in cells)
            {
                rowOfCells.Add(new Cell());
                rowOfCells.Insert(0, new Cell());
                newCells.Add(rowOfCells);
            }
            cells = newCells;
        }
    }
}
