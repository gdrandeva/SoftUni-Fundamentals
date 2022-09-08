using System;

namespace _9._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                bool isIntIsPalidrome = IsNumberPalindrome(input);
                Console.WriteLine(isIntIsPalidrome.ToString().ToLower());
            }
        }

        private static bool IsNumberPalindrome(string input)
        {
            int number = int.Parse(input);
            if (number >= 0 && number <= 9)
            {
                return true;
            }

            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] == input[input.Length - 1])
                {
                    return true;
                }
            }
        }


        //static void Main(string[] args)
        //{
        //    string input = Console.ReadLine();

        //    CheckIfItIsPalindrome(input);
        //}

        //static void CheckIfItIsPalindrome(string input)
        //{
        //    while (input != "END")
        //    {

        //        if (input[input.Length - 1] == input[0])
        //        {
        //            Console.WriteLine(true.ToString().ToLower());
        //        }
        //        else
        //        {
        //            Console.WriteLine(false.ToString().ToLower());
        //        }

        //        input = Console.ReadLine();
        //    }
    }
}
