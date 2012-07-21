using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameOfLife.IO;

namespace GameOfLife
{
    public class GameController
    {
        public static void Play(IInputFormatter inputter)
        {
        }

        public static object ShowBoard(IOutputFormatter outputter)
        {
            bool[,] data = new bool[,]
            {
                {true, true},
                {true, true}
            };
            return outputter.Output(data);
        }
    }
}
