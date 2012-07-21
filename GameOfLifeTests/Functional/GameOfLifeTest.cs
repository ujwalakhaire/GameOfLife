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
            IInputFormatter inputter = new InMemoryInputFormatter();

            GameController.Play();
        }
    }
}
