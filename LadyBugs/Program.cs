using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] initialIndices = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string[] bugs = new string[fieldSize];
            for (int i = 0; i < initialIndices.Length; i++)
            {
                 bugs[initialIndices[i]] = "bug"; 
            }
            //Console.WriteLine(string.Join(", ", bugs));

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] comArgs = input.Split();
                int initialIndex = int.Parse(comArgs[0]);
                string direction = comArgs[1];
                int flyLength = int.Parse(comArgs[2]);
                int endIndex = 0;

                if (direction == "right")
                {
                    endIndex = initialIndex + flyLength;
                }
                else if (direction == "left")
                {
                    endIndex = initialIndex - flyLength;
                }

                bugs[] = 



            }
        }
    }
}
