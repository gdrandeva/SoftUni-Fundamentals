using System;
using System.Linq;

namespace _4._Word_filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();



            string[] even = words.Where(wrd => wrd.Length % 2 == 0).ToArray();
            foreach (var item in even)
            {
                Console.WriteLine(string.Join(' ', item));
            }





            //for (int i = 0; i < words.Length; i++)
            //{
            //    if (words[i].Length %2 ==0)
            //    {
            //        Console.WriteLine(words[i]);
            //    }
            //}
        }
    }
}
