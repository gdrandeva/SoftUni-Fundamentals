using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> lastList = new List<int>();
            List<int> myList = new List<int>();
            double average = numbers.Average();
            const int topNumbers = 5;
            int count = 0;

            foreach (int number in numbers)
            {
                if (number > average)
                {
                    count++;
                    lastList.Add(number);
                }
            }
            lastList.Sort();
            lastList.Reverse();
            if (count>=topNumbers)
            {
                for (int i = 0; i < topNumbers; i++)
                {
                    myList.Add(lastList[i]);
                }
            }
            else if (count > 0 && count < topNumbers)
            {
                for(int i = 0; i < count; i++)
                {
                    myList.Add(lastList[i]);
                }
            }
            else if(count==0)
            {
                Console.WriteLine("No");
            }
            


            Console.WriteLine(string.Join(" ",  myList));
        }
    }
}
