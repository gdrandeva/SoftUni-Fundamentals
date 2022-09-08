using System;

namespace _11._Multiplication_table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiplier2 = int.Parse(Console.ReadLine());
            if (multiplier2<=10)
            {
                for (int i = multiplier2; i <= 10; i++)
                {
                    Console.WriteLine($"{number} X {multiplier2} = {number * multiplier2}");
                    multiplier2++;
                }
            }
            else if (multiplier2>10)
            {
                Console.WriteLine(($"{number} X {multiplier2} = {number * multiplier2}"));
            }

           
           
        }
    }
}
