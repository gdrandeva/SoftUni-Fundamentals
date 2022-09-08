using System;
using System.Linq;
namespace _2._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            SearchForVowels(input);
        }

        static void SearchForVowels(string text)
        {
            int count = 0;
           // Console.WriteLine(text.Count(vowels => "aouei".Contains(vowels)));

            foreach (char vowel in text)
            {
                if ("aouei".Contains(vowel))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
