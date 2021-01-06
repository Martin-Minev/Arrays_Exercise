using System;
using System.Linq;

namespace Lady_bugs
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
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] comArgs = input.Split();
                int initialIndex = int.Parse(comArgs[0]);
                string direction = comArgs[1];
                int flyLength = int.Parse(comArgs[2]);
                int endIndex = 0;

                if (initialIndex < 0 || initialIndex >= bugs.Length)
                {
                    break;
                }
                if (direction == "right")
                {
                    endIndex = initialIndex + flyLength;
                }
                else if (direction == "left")
                {
                    endIndex = initialIndex - flyLength;
                }
                if (endIndex < 0 || endIndex >= bugs.Length)
                {
                    bugs[initialIndex] = "";
                    break;
                }

                if (bugs[endIndex] == "bug")
                {
                    for (int i = 2; i < 999999; i++)
                    {
                        if (i * endIndex < 0 || i * endIndex >= bugs.Length)
                        {
                            bugs[initialIndex] = "";
                            break;
                        }
                        else
                        {
                            bugs[i * endIndex] = "bug";
                            bugs[initialIndex] = "";
                        }
                    }
                }
                else
                {
                    if (endIndex < 0 || endIndex >= bugs.Length)
                    {
                        break;
                    }
                    else
                    {
                        bugs[endIndex] = "bug";
                        bugs[initialIndex] = "";
                    }
                }
            }
            int[] result = new int[bugs.Length];
            for (int i = 0; i < result.Length; i++)
            {
                if (bugs[i] == "bug")
                {
                    result[i] = 1;
                }
                else
                {
                    result[i] = 0;
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
