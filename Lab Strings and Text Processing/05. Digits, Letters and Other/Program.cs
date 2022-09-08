using System;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {

//            Agd#53Dfg^&4F53	53453
//AgdDfgF
//#^&

            string input = Console.ReadLine();
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder symbols = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (char.IsDigit(currentChar))
                {
                    digits.Append(currentChar);
                }
                else if (char.IsLetter(currentChar))
                {
                    letters.Append(currentChar);
                }
                else
                {
                    symbols.Append(currentChar);
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);



        }
    }
}
