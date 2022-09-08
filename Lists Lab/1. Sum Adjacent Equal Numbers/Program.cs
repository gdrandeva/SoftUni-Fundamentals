using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();

            for (int i = 0; i < numbers.Count - 1; i++)
            {

                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] += numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    i = -1;


                }
            }
            Console.WriteLine(string.Join(" ", numbers));





            //double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            //List<double> numbers = new List<double>(input);


            //double currentIndex = 0;

            //for (int i = 0; i < numbers.Count - 1; i++)
            //{
            //    if (numbers[i] == numbers[i + 1])
            //    {
            //        currentIndex = numbers[i] + numbers[i + 1];
            //        numbers.RemoveRange(i, 2);
            //        numbers.Insert(i, currentIndex);
            //        i = -1;
            //    }

            //}
            //Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
