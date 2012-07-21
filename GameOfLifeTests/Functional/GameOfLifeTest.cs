using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace GameOfLifeTests.Functional
{
    [TestFixture]
    class GameOfLifeTest
    {
        [Test]
        public void UltimateTruthTest()
        {
            Assert.That(2 + 2, Is.EqualTo(4));
        }
    }
}
