using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

           int copiedNumber = number;
            int sum = 0;
            while (number>0)
            {
                int factNum = 1;
                int currentNum = number % 10;
                //copiedNumber += currentNum;
                number = number / 10;

                for (int i = 1; i <= currentNum; i++)
                {
                    factNum *= i;
                }
                    sum += factNum;
            }

            if (sum == copiedNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
