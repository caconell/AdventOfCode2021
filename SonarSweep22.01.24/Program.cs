using System;
using System.Collections.Generic;

namespace SonarSweep22._01._24
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Enter the day you would like to run:");

                string userChoice = Console.ReadLine().ToLower();

                switch (userChoice)
                {
                    case "1":
                        Day1.Run();
                        break;

                    case "2":
                        Day2.Run();
                        break;

                    case "3":
                        Day3.Run();
                        break;

                    default:
                        break;
                }
            }
        }
    }
}