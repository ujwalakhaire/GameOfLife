using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameOfLife.IO;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            GameController controller = new GameController();
            bool[,] pattern = new bool[,]
            {
                {true, true},
                {true, false}
            };
            IInputFormatter inputter = new InMemoryInputFormatter(pattern);
            controller.Play(inputter);
        }
    }
}
