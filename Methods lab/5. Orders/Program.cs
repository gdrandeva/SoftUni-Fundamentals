using System;

namespace _5._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            ProductsPrice(product, quantity);
        }

        static void ProductsPrice(string product, int quantity)
        {
            const double COFFEE = 1.50;
            const double WATER = 1.00;
            const double COKE = 1.40;
            const double SNACKS = 2.00;

            switch (product)
            {
                case "coffee":
                    Console.WriteLine($"{COFFEE * quantity:f2}");
                    break;
                case "water":
                    Console.WriteLine($"{WATER * quantity:f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{COKE * quantity:f2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{SNACKS * quantity:f2}");
                    break;
                default:
                    Console.WriteLine("Product not found!");
                    break;
            }
        }
        



    }
}
