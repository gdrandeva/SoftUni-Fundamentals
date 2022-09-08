using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2___Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command=="end")
                {
                    break;
                }
                string[] tokens = command.Split();
                string action = command[0];

                switch (action)
                {
                    case "swap":
                        Swap(int.Parse(tokens[1]), int.Parse(tokens[2]), numbers);
                        break;
                    case "multiply":
                        break;
                    case "decrease":
                        break;
                    default:
                        break;
                }



            }

            Console.WriteLine(string.Join(",",numbers));
        }

        static void Swap(int firstIndex, int secondIntex, List<int> numbers)
        {
            
            int temp = numbers[firstIndex];

            numbers[firstIndex] == secondNumber;
            numbers[secondIntex] == temp;
        }
    }
}
