using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using GameOfLife;

namespace GameOfLifeTests.Functional
{
    [TestFixture]
    class GameOfLifeTest
    {
        [Test]
        public void BlockPatternTest()
        {
            GameController.Play();
        }
    }
}
