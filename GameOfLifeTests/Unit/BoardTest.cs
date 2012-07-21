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
            Cell firstCell = board.Cells[0];
            Assert.That(firstCell.CurrentState, Is.False);
            Assert.That(firstCell.X, Is.EqualTo(0));
            Assert.That(firstCell.Y, Is.EqualTo(0));
        }

        [Test]
        public void LastCellDataAccuracyOfSquareBoardTest()
        {
            CreateSquareBoard();
            Cell lastCell = board.Cells[board.Cells.Count-1];
            Assert.That(lastCell.CurrentState, Is.True);
            Assert.That(lastCell.X, Is.EqualTo(2));
            Assert.That(lastCell.Y, Is.EqualTo(2));
        }

        [Test]
        public void RandomCellDataAccuracyOfNonSquareBoardTest()
        {
            CreateNonSquareBoard();
            Cell cell = board.Cells[3];
            Assert.That(cell.CurrentState, Is.False);
            Assert.That(cell.X, Is.EqualTo(1));
            Assert.That(cell.Y, Is.EqualTo(0));
        }
    }
}
