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
        public void TheUltimateTruthTest()
        {
            Assert.That(1, Is.EqualTo(1));
        }
    }
}
