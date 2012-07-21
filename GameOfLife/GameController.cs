using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameOfLife.IO;

namespace GameOfLife
{
    public class GameController
    {
        private Board board;

        public void Play(IInputFormatter inputter)
        {
            board = new Board(inputter.Format());
        }

        public object ShowBoard(IOutputFormatter outputter)
        {
            return outputter.Output(board.Show());
        }
    }
}
