using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;

            if (array.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = 0; i < array.Length; i++)
            {
                leftSum = 0;
                for (int j = i; j > 0; j--)
                {
                    int currentLeftElement = j - 1;
                    if (j>0)
                    {
                        leftSum += array[currentLeftElement];
                    }
                }
                rightSum = 0;
                for (int k = i; k < array.Length; k++)
                {
                    
                    int currentRightElement = k + 1;
                    if (k<array.Length-1)
                    {
                        rightSum += array[currentRightElement];
                    }
                   
                }
                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }

            }
            Console.WriteLine("no");
        }
    }
}
