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
                return;
            }

            IInputFormatter inputter = new FileInputter(args[0]);
            Console.WriteLine("\nPattern present in file : ");
            inputter.Display();

            IOutputFormatter outputter = new ConsoleOutputFormatter();
            GameController controller = new GameController();
            controller.PlayMultipleGenerations(inputter, outputter);
        }

        private static void DisplayTickOfFileinput()
        {
            Console.Write("Enter file path : ");
            string filePath = Console.ReadLine();

            Console.Write("\nEnter number of generations : ");
            int generationCount;

            if(int.TryParse(Console.ReadLine(), out generationCount))
            {
                IInputFormatter inputter = new FileInputter(filePath);
                Console.WriteLine("\nPattern present in file : ");
                inputter.Display();

                IOutputFormatter outputter = new ConsoleOutputFormatter();
                GameController controller = new GameController();
                controller.Play(inputter);

                //Console.WriteLine("{0}th Tick of inputted Pattern : ", generationCount);
                controller.ShowBoard(outputter);

                Console.WriteLine("**************************************************");
            }
        }

    }
}
