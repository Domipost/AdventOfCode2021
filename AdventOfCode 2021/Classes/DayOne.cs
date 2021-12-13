using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace AdventOfCode_2021.Classes
{
    public class DayOne
    {
        public static List<string> GetInput()
        {
            string input = @"C:\Users\Dominick\source\repos\AdventOfCode2021\AdventOfCode 2021\InputFiles\DayOne.txt";

            return File.ReadAllLines(input).ToList();
        }

        public static int Answer1()
        {
            var input = GetInput();

            int counter = 0;

            for (int i = 0; i < input.Count - 1; i++)
            {
                int currentLine = int.Parse(input[i]);
                int nextLine = int.Parse(input[i + 1]);

                if (currentLine < nextLine)
                {
                    counter++;
                }

            }

            return counter;
        }

        public static int Answer2()
        {
            return 0;
        }
    }
}
