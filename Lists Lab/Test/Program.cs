using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integerList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> reversedList = new List<int>();
            bool isContainsNegativeNumbers = CheckForNegativeNumbers();
            for (int i = 0; i <= integerList.Count-1; i++)
            {
                if (isContainsNegativeNumbers)
                {
                    Console.WriteLine("empty");
                }
                if (integerList[i]>0)
                {
                    reversedList.Add(integerList[i]);
                }
                if (integerList[i]<0)
                {
                    continue;
                }
                
                
                
            }
            reversedList.Reverse();
            Console.WriteLine(string.Join(" ", reversedList));
        }

        static bool CheckForNegativeNumbers(List<int> integerList)
        {
            for (int i = 1; i < integerList.Count; i++)
            {
                if (integerList[i] < 0)
                {
                    integerList[i];
                }
            }
        }
    }
}



