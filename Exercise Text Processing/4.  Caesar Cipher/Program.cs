using System;
using System.Text;

namespace _4.__Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            StringBuilder sb = new StringBuilder();


            for (int i = 0; i < message.Length; i++)
            {
                char encrypted = (char)(message[i] + 3);
                sb.Append(encrypted);
            }

            Console.WriteLine(sb);

        }
    }
}
