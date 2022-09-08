using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<string> orderedProducts = new List<string>();

            for (int i = 0; i < number; i++)
            {
                string product = Console.ReadLine();
                orderedProducts.Add(product);

            }
            orderedProducts.Sort();
            int count = 1;
            foreach (var product in orderedProducts)
            {
                Console.WriteLine($"{count}.{product}");
                count++;
            }
        }

    }
}



