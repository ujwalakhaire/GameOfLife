using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using GameOfLife;
using GameOfLife.IO;

namespace GameOfLifeTests.Functional
{
    [TestFixture]
    class GameOfLifeTest
    {
        [Test]
        public void BlockPatternTest()
        {
            bool[,] blockPattern = new bool[,]
            {
                {true, true},
                {true, true}
            };
            IInputFormatter inputter = new InMemoryInputFormatter(blockPattern);
            GameController.Play(inputter);

            // The block pattern is expected to remain the same.
            bool[,] expectedPattern = blockPattern;

            IOutputFormatter outputter = new InMemoryOutputFormatter();

            Assert.That(GameController.ShowBoard(outputter), Is.EqualTo(expectedPattern));
        }
    }
}
