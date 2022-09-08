using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integerArray = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            //1 4 3 2
            for (int i = 0; i < integerArray.Length; i++)
            {
                int currentNumber = integerArray[i];
                bool isCurrentNumBigger = true;
                for (int j = i+1; j < integerArray.Length; j++)
                {
                    int nextNumber = integerArray[j];
                    if (currentNumber <= nextNumber)
                    {
                        isCurrentNumBigger = false;
                    }
                
                }
                if (isCurrentNumBigger==true)
                {
                    Console.Write($"{currentNumber} ");
                }
                
            }
            
        }
    }
}
