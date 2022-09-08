using System;
using System.Linq;

namespace _7._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string longestArr = string.Empty;
            int countCheckingLongestArr = 0;
            int currentCount = 0;

            //2 1 1 2 3 3 2 2 2 1

            for (int i = 0; i < input.Length-1; i++)
            {
               
                if (input[i]!=input[i+1])
                {
                    currentCount = 0;
                    
                }
                else
                {
                    currentCount++;
                    if (currentCount > countCheckingLongestArr)
                    {
                        countCheckingLongestArr = currentCount;
                        longestArr = input[i];
                    }
                }
                
            }
            for (int j = 0; j <= countCheckingLongestArr; j++)
            {
                Console.Write($"{ longestArr} ");
            }
        }
    }
}
