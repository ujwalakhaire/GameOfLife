using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        public void PlayMultipleGenerations(IInputFormatter inputter, IOutputFormatter outputter)
        {
            board = new Board(inputter.Format());
            int generationCount = 0;
            while (true)
            {
                Console.WriteLine("Generation : {0}", generationCount++);
                outputter.Output(board.Show());
                Tick();
                Console.WriteLine("\nEnter any key to see next generation : ");
                Console.ReadKey();
            }
        }

        public object ShowBoard(IOutputFormatter outputter)
        {
            return outputter.Output(board.Show());
        }

        private void Tick()
        {
            board.PrepareForNextGeneration();
            // 1. Iterate through cells.
            // 2. For each cell, determine number of live and dead neighbors.
            // 3. Decide next stage.
            foreach (Cell cell in board.Cells)
                cell.NextState = RuleManager.DecideStateInNextGeneration(cell, board.NeighborsOf(cell));     
            board.ChangeToNextGeneration();

            board.CleanBoundary();
        }

        internal void Play(IInputFormatter inputter, int generationCount)
        {
            board = new Board(inputter.Format());
            for (int index = 0; index < generationCount; index++)
                Tick();
        }
    }
}
