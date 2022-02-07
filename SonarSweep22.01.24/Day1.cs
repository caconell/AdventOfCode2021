using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonarSweep22._01._24
{
    internal static class Day1
    {
        public static void Run()
        {
            Console.WriteLine($"Part 1: {FindDepths()}");
            Console.WriteLine($"Part 2: {FindWindowDepths()}");

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        private static int FindDepths()
        {
            var input = ParseInput(Properties.Resources.input);
            var depths = DetermineDepths(input);

            return depths;
        }

        private static int DetermineDepths(List<int> depths)
        {
            int counter = 0;
            for (int i = 1; i < depths.Count; i++)
            {
                if (depths[i] > depths[i - 1])
                    counter += 1;
            }
            return counter;
        }

        private static int FindWindowDepths()
        {
            var input = ParseInput(Properties.Resources.input);
            var windowDepths = DetermineWindowDepths(input);
            return windowDepths;
        }

        private static int DetermineWindowDepths(List<int> depths)
        {
            int counter = 0;
            int lastSum = int.MaxValue;
            for (int i = 0; i < depths.Count - 2; i++)
            {
                int sum = depths[i] + depths[i + 1] + depths[i + 2];
                if (sum > lastSum) counter++;
                lastSum = sum;
            }
            return counter;
        }

        private static List<int> ParseInput(string input)
        {
            string[] lines = input.Split("\n");
            List<int> depths = new List<int>();

            foreach (var line in lines)
            {
                if (Int32.TryParse(line.Trim(), out int depth))
                {
                    depths.Add(depth);
                }
            }
            return depths;
        }
    }
}