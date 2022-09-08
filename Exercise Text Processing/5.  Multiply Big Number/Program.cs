using System;
using System.Text;

namespace _5.__Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int singleNum = int.Parse(Console.ReadLine());

            if (singleNum == 0)
            {
                Console.WriteLine(0);
                return;
            }
            StringBuilder sb = new StringBuilder();
            int remainder = 0;

            for (int i = number.Length-1; i >= 0; i--)
            {
                char lastNum = number[i];
                int lastNumAsDigit = int.Parse(lastNum.ToString());

                int result = lastNumAsDigit * singleNum+remainder;

                sb.Append(result%10);

                remainder = result / 10;
            }
            if (remainder!=0)
            {
                sb.Append(remainder);

            }
            StringBuilder reversedString = new StringBuilder();
            for (int i = sb.Length-1; i >=0; i++)
            {
                reversedString.Append(sb[i]);
            }
            Console.WriteLine(sb);

        }
    }
}
