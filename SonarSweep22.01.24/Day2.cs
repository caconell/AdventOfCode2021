using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonarSweep22._01._24
{
    internal static class Day2
    {
        public static void Run()
        {
            Console.WriteLine($"Part 1: {FindPosition()}");
            Console.WriteLine($"Part 2: {FindAimedPosition()}");

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        private static int FindPosition()
        {
            var input = ParseInput(Properties.Resources.inputDay2);
            var position = DeterminePosition(input);

            return position;
        }

        private static int DeterminePosition(List<(string, int)> directions)
        {
            var position = 0;
            var depth = 0;

            foreach (var (command, argument) in directions)
            {
                switch (command)
                {
                    case "forward":
                        position += argument;
                        break;

                    case "up":
                        depth -= argument;
                        break;

                    case "down":
                        depth += argument;
                        break;
                }
            }
            return position * depth;
        }

        private static int FindAimedPosition()
        {
            var input = ParseInput(Properties.Resources.inputDay2);
            var aimedPosition = DetermineAimedPosition(input);

            return aimedPosition;
        }

        private static int DetermineAimedPosition(List<(string, int)> directions)
        {
            var position = 0;
            var depth = 0;
            var aim = 0;

            foreach (var (command, argument) in directions)
            {
                switch (command)
                {
                    case "forward":
                        position += argument;
                        depth += argument * aim;
                        break;

                    case "up":
                        aim -= argument;
                        break;

                    case "down":
                        aim += argument;
                        break;
                }
            }
            return position * depth;
        }

        private static List<(string, int)> ParseInput(string input)
        {
            var lines = File.ReadLines(@"C:\Users\cacon\source\repos\SonarSweep22.01.24\inputDay2.txt").ToList();

            //var lines = input.Split("\n").ToList();

            var directions = lines.Select(s =>
            {
                var parts = s.Split(" ");
                return (parts[0], int.Parse(parts[1]));
            }).ToList();

            return directions;
        }
    }
}