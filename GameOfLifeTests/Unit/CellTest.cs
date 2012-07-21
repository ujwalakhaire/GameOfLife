using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using GameOfLife;

namespace GameOfLifeTests.Unit
{
    [TestFixture]
    class CellTest
    {
        private Cell cell;

        [TestFixtureSetUp]
        public void SetUp()
        {
            cell = new Cell(true, 17, 19);
        }

        [Test]
        public void ToStringTest()
        {
            Assert.That(cell.ToString(), Is.EqualTo("GameOfLife.Cell <current State: True, X: 17, Y: 19>"));
        }

        [Test]
        public void CellEqualityTest()
        {
            Assert.That(cell, Is.EqualTo(new Cell(true, 17, 19)));
        }
    }
}
