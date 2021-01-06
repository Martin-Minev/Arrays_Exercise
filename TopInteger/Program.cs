using System;
using System.Linq;

namespace TopInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                               .Split()
                               .Select(int.Parse)
                               .ToArray();
            bool isBigger = true;
            for (int i = 0; i < arr.Length; i++)
            {
                int currentInt = arr[i];
                for (int j = 1 + 1; j < arr.Length; j++)
                {
                    if (arr[j] >= currentInt)
                    {
                        isBigger = false;
                        break;
                    }
                }
                if (!isBigger)
                {
                    Console.WriteLine(currentInt + " ");
                }

                isBigger = true;
            }
        }
    }
}
