using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] nonSquarePattern = new bool[,]
            {
                {false, true, false},
                {false, true, false}
            };
            Board board = new Board(nonSquarePattern);

            IList<Cell> expectedNeighbors = new List<Cell>()
                    { new Cell(true, 0, 1),
                      new Cell(false, 1, 0), 
                      new Cell(true, 1, 1) };

            Cell firstCell = board.Cells[0];
            IList<Cell> actualNeighbors = board.NeighborsOf(firstCell);
        }
    }
}
