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
            DisplayTickOfSampleInMemoryInputs();
            //DisplayTickOfFileinput();
            Console.WriteLine("Enter any key to exit");
            Console.ReadKey();
        }

        private static void DisplayTickOfSampleInMemoryInputs()
        {
            DisplayTickOfInMemoryBlockPattern();
            DisplayTickOfInMemoryBoatPattern();
            DisplayTickOfInMemoryBlinkerPattern();
            DisplayTickOfInMemoryToadPattern();
        }

        private static void DisplayTickOfInMemoryBlockPattern()
        {
            bool[,] blockPattern = new bool[,]
            {
                {true, true},
                {true, true}
            };

            IInputFormatter inputter = new InMemoryInputFormatter(blockPattern);
            Console.WriteLine("Input<Block Pattern>:");
            inputter.Display();

            IOutputFormatter outputter = new ConsoleOutputFormatter();
            GameController controller = new GameController();
            controller.Play(inputter);

            Console.WriteLine("First Tick of Block Pattern:");
            controller.ShowBoard(outputter);

            Console.WriteLine("**************************************************");
        }

        private static void DisplayTickOfInMemoryBoatPattern()
        {
            bool[,] boatPattern = new bool[,]
            {
                {true, true, false},
                {true, false, true},
                {false, true, false}
            };

            IInputFormatter inputter = new InMemoryInputFormatter(boatPattern);
            Console.WriteLine("Input<Boat Pattern>:");
            inputter.Display();

            IOutputFormatter outputter = new ConsoleOutputFormatter();
            GameController controller = new GameController();
            controller.Play(inputter);

            Console.WriteLine("First Tick of Boat Pattern:");
            controller.ShowBoard(outputter);

            Console.WriteLine("**************************************************");
        }

        private static void DisplayTickOfInMemoryBlinkerPattern()
        {
            bool[,] blinkerPattern = new bool[,]
            {
                {false, true, false},
                {false, true, false},
                {false, true, false}
            };

            IInputFormatter inputter = new InMemoryInputFormatter(blinkerPattern);
            Console.WriteLine("Input<Blinker Pattern>:");
            inputter.Display();

            IOutputFormatter outputter = new ConsoleOutputFormatter();
            GameController controller = new GameController();
            controller.Play(inputter);

            Console.WriteLine("First Tick of Blinker Pattern:");
            controller.ShowBoard(outputter);

            Console.WriteLine("**************************************************");
        }

        private static void DisplayTickOfInMemoryToadPattern()
        {
            bool[,] toadPattern = new bool[,]
            {
                {false, true, false},
                {false, true, false},
                {false, true, false}
            };

            IInputFormatter inputter = new InMemoryInputFormatter(toadPattern);
            Console.WriteLine("Input<Toad Pattern>:");
            inputter.Display();

            IOutputFormatter outputter = new ConsoleOutputFormatter();
            GameController controller = new GameController();
            controller.Play(inputter);

            Console.WriteLine("First Tick of Toad Pattern:");
            controller.ShowBoard(outputter);

            Console.WriteLine("**************************************************");
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
