using System;
using System.Text;

namespace _5.__Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNum = Console.ReadLine();
            int digit = int.Parse(Console.ReadLine());

            if (digit==0)
            {
                Console.WriteLine(0);
                return;
            }

            StringBuilder biggestNum = new StringBuilder();
            int remainder = 0;

            for (int i = bigNum.Length-1; i >=0; i--)
            {
                int lastDigit = int.Parse(bigNum[i].ToString());

                int product = lastDigit * digit + remainder;

                biggestNum.Append(product%10);
                remainder = product / 10;
            }
            if (remainder!=0)
            {
                biggestNum.Append(remainder);
            }
            StringBuilder reversedBiggestNum = new StringBuilder();
            for (int i = biggestNum.Length-1; i >= 0; i--)
            {
                reversedBiggestNum.Append(biggestNum[i]);
            }

            Console.WriteLine(reversedBiggestNum);
            
        }
    }
}
