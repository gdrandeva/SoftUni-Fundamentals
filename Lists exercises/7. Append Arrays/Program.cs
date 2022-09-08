using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();
            int numberOfArrays = input.Length;
            List<int> finalListOfArrays = new List<int>();
            
            for (int i = 0; i < numberOfArrays; i++)
            {
                int[] currArr = input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                foreach (int array in currArr)
                {
                    finalListOfArrays.Add(array);
                }

            }

            Console.WriteLine(string.Join(" ", finalListOfArrays));
        }
    }
}
