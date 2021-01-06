using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                               .Split()
                               .Select(int.Parse)
                               .ToArray();
            int bestCounter = 0;
            int bestIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int currentElememnt = arr[i];
                int counter = 1;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (currentElememnt == arr[j])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (counter > bestCounter)
                {
                    bestCounter = counter;
                    bestIndex = i;
                }
            }

            for (int i = 0; i < bestCounter; i++)
            {
                Console.Write(arr[bestIndex] + " ");
            }
        }
    }
}
