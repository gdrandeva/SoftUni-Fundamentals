using System;

namespace _2._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            //int numInput = int.Parse(Console.ReadLine());

            //int finalSum = 0;

            //while (numInput!=0)
            //{
            //    int lastDigit = numInput % 10;
            //    finalSum += lastDigit;

            //    numInput /= 10;
            //}

            //Console.WriteLine(finalSum);

            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            int finalSum = 0;

            for (int value = 0; value < charArray; value++)
            {
                finalSum += int.Parse(charArray[value].ToString());
            }

            Console.WriteLine(finalSum);
        }
    }
}
