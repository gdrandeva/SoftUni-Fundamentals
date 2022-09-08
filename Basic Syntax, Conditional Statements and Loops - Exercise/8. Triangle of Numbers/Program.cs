using System;

namespace _8._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int triangleSide = int.Parse(Console.ReadLine());

            for (int i = 1; i <= triangleSide ; i++)
            {
                for (int k = i; k > 0; k--)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
           


        }
    }
}
