using System;
using System.Linq;

namespace _2._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] secondArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


            foreach (var sec in secondArray)
            {
                if (firstArray.Contains(sec))
                {
                    Console.Write($"{sec} ");
                }
            }
        }
    }
}
