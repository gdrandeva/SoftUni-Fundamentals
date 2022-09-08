using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> bannedWords = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).ToList();
            string text = Console.ReadLine();
                
            StringBuilder bannedWordWithAsterisks = new StringBuilder();

            for (int i = 0; i < bannedWords.Count; i++)
            {
                string bannedWord = bannedWords[i];
                int lenght = bannedWord.Length;

                for (int k = 0; k < bannedWords[i].Length; k++)
                {
                    bannedWordWithAsterisks.Append("*");
                }

                text=text.Replace(bannedWord, bannedWordWithAsterisks.ToString());
                bannedWordWithAsterisks.Clear();
            }
            Console.WriteLine(text);

        }
    }
}
