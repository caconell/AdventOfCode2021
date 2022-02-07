using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonarSweep22._01._24
{
    internal static class Day3
    {
        public static void Run()
        {
            Console.WriteLine($"Part 1: {FindPowerLevel()}");
            //Console.WriteLine($"Part 2: {}");

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        private static int FindPowerLevel()
        {
            var input = ParseInput(Properties.Resources.inputDay3);
            var powerLevel = DeterminePowerLevel(input);

            return powerLevel;
        }

        private static int DeterminePowerLevel(List<string> reports)
        {
            //var gamma = "";
            var onesCounter = 0;
            var zerosCounter = 0;

            //need to get to the first element of the list then each element of each string in the list
            foreach (var report in reports)
            {
                for (var i = 0; i < reports[0].Length; i++)
                {
                    if (reports[0] == "1")
                        onesCounter += 1;
                }
            }

            return onesCounter;
        }

        private static List<string> ParseInput(string input)
        {
            string[] lines = input.Split("\n");
            var reports = lines.ToList();
            //List<int> reports = new List<int>();

            //foreach (var line in lines)
            //{
            //    if (Int32.TryParse(line.Trim(), out int report))
            //    {
            //        reports.Add(report);
            //    }
            //}
            return reports;
        }
    }
}