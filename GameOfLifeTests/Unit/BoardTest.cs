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
        [Test]
        public void CellsCountOfSquareBoardTest()
        {
            bool[,] pattern = new bool[,]
            {
                {false, true, false},
                {false, true, false},
                {false, true, false}
            };

            Board board = new Board(pattern);

            Assert.That(board.Cells.Count, Is.EqualTo(9));
        }
    }
}
