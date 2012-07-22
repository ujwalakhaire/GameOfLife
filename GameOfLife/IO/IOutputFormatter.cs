using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLife.IO
{
    public interface IOutputFormatter
    {
        object Output(IEnumerable<IEnumerable<bool>> data);
    }
}
