using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLife
{
    public class RuleManager
    {
        internal static bool DecideStateInNextGeneration(Cell cell, IList<Cell> neighbors)
        {
            var liveNeighborCount = (from neighboringCell in neighbors
                        where neighboringCell.CurrentState.Equals(true)
                        select neighboringCell).Count();
            bool nextStage = false;

            if (cell.CurrentState)
                nextStage = Enumerable.Range(2, 2).Contains(liveNeighborCount);
            else
                nextStage = (liveNeighborCount == 3);

            return nextStage;
        }
    }
}
