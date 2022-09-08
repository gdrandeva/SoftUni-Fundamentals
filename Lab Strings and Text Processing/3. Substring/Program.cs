using System;
using System.Text;

namespace _3._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            StringBuilder secondWord = new StringBuilder(Console.ReadLine());

            while (secondWord.ToString().Contains(firstWord))
            {

                int index = secondWord.ToString().IndexOf(firstWord);

              
                secondWord.Remove(index, firstWord.Length);
                    
            }
            Console.WriteLine(secondWord);

        }
    }
}
