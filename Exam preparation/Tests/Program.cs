using System;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            double partPrice = 0;
            double priceWithoutTax = 0;
            double totalPrice = 0;

            string input = Console.ReadLine();

            while (input!= "special" && input!= "regular")
            {
                partPrice = double.Parse(input);
                if (partPrice<0)
                {
                    Console.WriteLine("Invalid price!");
                    input = Console.ReadLine();
                    continue;
                }
                priceWithoutTax += partPrice;
                totalPrice =priceWithoutTax+ priceWithoutTax * 0.2;
                

                input = Console.ReadLine();
            }
            
            switch (input)
            {
                case "special":
                    totalPrice =totalPrice-totalPrice *0.1;
                    if (totalPrice == 0)
                    {
                        Console.WriteLine("Invalid order!");
                        break;
                    }
                    Console.WriteLine("Congratulations you've just bought a new computer!");
                    Console.WriteLine($"Price without taxes: {priceWithoutTax:f2}$");
                    Console.WriteLine($"Taxes: {priceWithoutTax*0.2:f2}$");
                    Console.WriteLine("-----------");
                    Console.WriteLine($"Total price: {totalPrice:f2}$");
                    break;
                case "regular":
                    if (totalPrice == 0)
                    {
                        Console.WriteLine("Invalid order!");
                        break;
                    }

                    Console.WriteLine("Congratulations you've just bought a new computer!");
                    Console.WriteLine($"Price without taxes: {priceWithoutTax:f2}$");
                    Console.WriteLine($"Taxes: {priceWithoutTax * 0.2:f2}$");
                    Console.WriteLine("-----------");
                    Console.WriteLine($"Total price: {totalPrice:f2}$");
                    
                    break;
                default:
                    break;
            }
            

            
        }
    }
}
