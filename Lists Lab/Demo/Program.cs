using System;
using System.Collections.Generic;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {



            List<string> names = new List<string>();

            names.Add("Maria");
            names.Add("Ivan");
            names.Add("Peter");
            names.Add("Lili");
            names.Add("Sara");

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            Console.WriteLine(string.Join(",", names));

            names.Insert(1, "Gergana");
            Console.WriteLine(string.Join(", ", names));

            Console.WriteLine($"Count: {names.Count}");
            names.Remove("Lili");
            Console.WriteLine(string.Join(",", names));


            bool isNameInList = names.Contains("Koko");
            if (isNameInList)
            {
                Console.WriteLine("Gergana is in the list");
            }
            else
            {
                Console.WriteLine("No");
            }
            names.Sort();
            names.Reverse();
            Console.WriteLine(string.Join(",", names));

            List<int> numbers = new List<int>
            { 1,
            2,
            3,
            4};
            numbers.Reverse();
            Console.WriteLine(string.Join(":", numbers));

            names.Sort()
        }
    }
}
