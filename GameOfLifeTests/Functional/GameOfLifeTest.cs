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

        private void PlayGameWithInput(bool[,] pattern)
        {
            IInputFormatter inputter = new InMemoryInputFormatter(pattern);
            controller.Play(inputter);
        }

        [Test]
        public void BlockPatternTest()
        {
            bool[,] pattern = new bool[,]
            {
                {true, true},
                {true, true}
            };
            PlayGameWithInput(pattern);

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
            PlayGameWithInput(pattern);

            // The block pattern is expected to remain the same.
            bool[,] expectedPattern = pattern;
            Assert.That(controller.ShowBoard(outputter), Is.EqualTo(expectedPattern));
        }

        [Test]
        public void BlinkerPatternTest()
        {
            bool[,] pattern = new bool[,]
            {
                {false, true, false},
                {false, true, false},
                {false, true, false}
            };
            PlayGameWithInput(pattern);

            bool[,] expectedPattern = new bool[,]
            {
                {false, false, false},
                {true, true, true},
                {false, false, false}
            };
            Assert.That(controller.ShowBoard(outputter), Is.EqualTo(expectedPattern));
        }

        [Test]
        [Ignore]
        public void ToadPatternTest()
        {
            bool[,] pattern = new bool[,]
            {
                {false, true, true, true},
                {true, true, true, false}
            };
            PlayGameWithInput(pattern);

            bool[,] expectedPattern = new bool[,]
            {
                {false, false, true, false},
                {true, false, false, true},
                {true, false, false, true},
                {false, true, false, false}
            };
            Assert.That(controller.ShowBoard(outputter), Is.EqualTo(expectedPattern));
        }
    }
}
