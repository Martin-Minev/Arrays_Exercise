using System;
using System.Collections.Generic;
using System.Linq;

namespace Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                              .Split()
                              .Select(int.Parse)
                              .ToArray();
            List<int> top = new List<int>();
            bool isBigger = false;
            for (int i = 0; i < arr.Length; i++)
            {
                int currentInt = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (currentInt >= arr[j])
                    {
                        isBigger = true;
                    }
                    else
                    {
                        isBigger = false;
                        break;
                    }
                }
                if (i == arr.Length - 1)
                {
                    isBigger = true;
                }
                if (isBigger == true)
                {
                    top.Add(currentInt);
                }
                isBigger = false;
            }
            Console.Write(string.Join(" ", top));
        }
    }
}
