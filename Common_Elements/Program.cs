using System;

namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split();

            string[] secondArray = Console.ReadLine().Split();

            foreach (var elementTwo in secondArray)

            {

                for (int i = 0; i < firstArray.Length; i++)
                {

                    if (elementTwo == firstArray[i])
                    {
                        Console.Write(elementTwo + " ");
                        break;
                    }
                }

            }
        }
    }
}
