using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using GameOfLife;

namespace GameOfLifeTests.Unit
{
    [TestFixture]
    class BoardTest
    {
        private Board board;

        private void CreateSquareBoard()
        {
            bool[,] squarePattern = new bool[,]
            {
                {false, true, false},
                {false, true, false},
                {false, true, true}
            };
            board = new Board(squarePattern);
        }

        private void CreateNonSquareBoard()
        {
            bool[,] nonSquarePattern = new bool[,]
            {
                {false, true, false},
                {false, true, false}
            };
            board = new Board(nonSquarePattern);
        }

        [Test]
        public void CellsCountOfSquareBoardTest()
        {
            CreateSquareBoard();
            Assert.That(board.Cells.Count, Is.EqualTo(9));
        }

        [Test]
        public void CellsCountOfNonSquareBoardTest()
        {
            CreateNonSquareBoard();
            Assert.That(board.Cells.Count, Is.EqualTo(6));
        }

        [Test]
        public void FirstCellDataAccuracyOfSquareBoardTest()
        {
            CreateSquareBoard();
            Assert.That(board.Cells[0], Is.EqualTo(new Cell(false, 0, 0)));
        }

        [Test]
        public void LastCellDataAccuracyOfSquareBoardTest()
        {
            CreateSquareBoard();
            Assert.That(board.Cells[board.Cells.Count - 1], Is.EqualTo(new Cell(true, 2, 2)));
        }

        [Test]
        public void RandomCellDataAccuracyOfNonSquareBoardTest()
        {
            CreateNonSquareBoard();
            Assert.That(board.Cells[3], Is.EqualTo(new Cell(false, 1, 0)));
        }

        [Test]
        public void FirstCellNeighborsOfNonSquaredBoardTest()
        {
            CreateNonSquareBoard();
            IList<Cell> expectedNeighbors = new List<Cell>()
                    { new Cell(true, 0, 1),
                      new Cell(false, 1, 0), 
                      new Cell(true, 1, 1) };

            Cell firstCell = board.Cells[0];
            IList<Cell> actualNeighbors = board.NeighborsOf(firstCell);

            Assert.That(actualNeighbors, Is.EqualTo(expectedNeighbors));
        }
    }
}
