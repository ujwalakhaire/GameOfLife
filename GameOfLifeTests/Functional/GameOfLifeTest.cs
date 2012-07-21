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
        GameController controller;
        IOutputFormatter outputter;

        [TestFixtureSetUp]
        public void Setup()
        {
            controller = new GameController();
            outputter = new InMemoryOutputFormatter();
        }

        [Test]
        public void patternTest()
        {
            bool[,] pattern = new bool[,]
            {
                {true, true},
                {true, true}
            };

            IInputFormatter inputter = new InMemoryInputFormatter(pattern);
            controller.Play(inputter);

            // The block pattern is expected to remain the same.
            bool[,] expectedPattern = pattern;
            Assert.That(controller.ShowBoard(outputter), Is.EqualTo(expectedPattern));
        }

        [Test]
        public void BoatPatternTest()
        {
            bool[,] pattern = new bool[,]
            {
                {true, true, false},
                {true, false, true},
                {false, true, false}
            };

            IInputFormatter inputter = new InMemoryInputFormatter(pattern);
            controller.Play(inputter);

            // The block pattern is expected to remain the same.
            bool[,] expectedPattern = pattern;
            Assert.That(controller.ShowBoard(outputter), Is.EqualTo(expectedPattern));
        }
    }
}
