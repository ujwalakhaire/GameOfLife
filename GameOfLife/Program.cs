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
            if (args.Length == 0)
            {
                Console.WriteLine("Please enter a valid file path.");
                Console.WriteLine("\nEnter any key to close the application.");
                Console.ReadKey();
                return;
            }

            IInputFormatter inputter = new FileInputter(args[0]);
            IOutputFormatter outputter = new ConsoleOutputFormatter();
            GameController controller = new GameController();
            controller.PlayMultipleGenerations(inputter, outputter);
        }
    }
}
