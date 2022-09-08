using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string repeatingChars = Console.ReadLine();
            
            StringBuilder replacedSequenceOfChars = new StringBuilder();

            replacedSequenceOfChars.Append(repeatingChars[0]);
            for (int i = 1; i < repeatingChars.Length; i++)
            {
                char currentChar = repeatingChars[i];
                char previousChar = repeatingChars[i - 1];

                if (currentChar!=previousChar)
                {
                    replacedSequenceOfChars.Append(currentChar);
                }
                else
                {
                    continue; 
                }


            }

            Console.WriteLine(replacedSequenceOfChars);

           
        }
    }
}
