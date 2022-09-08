using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int biggerCount = Math.Max(firstList.Count, secondList.Count);
            List<int> listFromOtherTwo = new List<int>();

            for (int i = 0; i < biggerCount; i++)
            {
                if (firstList.Count > i)
                {
                    listFromOtherTwo.Add(firstList[i]);
                }
                if (secondList.Count > i)
                {
                    listFromOtherTwo.Add(secondList[i]);
                }

            }
            Console.WriteLine(string.Join(" ", listFromOtherTwo));


        }

    }
}



