using System;

namespace _4.__Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string caesarCipher = string.Empty;

            for (int i = 0; i <= input.Length-1; i++)
            {
                caesarCipher += (char)(input[i] + 3);
            }

            Console.WriteLine(caesarCipher);
        }
    }
}
