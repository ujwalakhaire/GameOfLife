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
            Tick();
        }

        public object ShowBoard(IOutputFormatter outputter)
        {
            return outputter.Output(board.Show());
        }

        private void Tick()
        {
            // 1. Iterate through cells.
            // 2. For each cell, determine number of live and dead neighbors.
            // 3. Apply rules which is dependent on current state of the cell and it's number of live and dead neighbors.

            foreach (Cell cell in board.Cells)
            {
               // RuleManager.ApplyRules(cell, board.NeighborsOf(cell));
            }
        }
    }
}
