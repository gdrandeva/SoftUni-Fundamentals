using System;
using System.Linq;

namespace _8._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int magicNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i+1; j <= array.Length-1; j++)
                {
                    int sum = array[i] + array[j];
                    if (sum==magicNum)
                    {
                        Console.WriteLine($"{array[i]} {array[j]}");
                    }
                }
                
               
            }
        }
    }
}
