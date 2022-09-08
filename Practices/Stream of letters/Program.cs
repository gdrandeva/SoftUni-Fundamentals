using System;

namespace Stream_of_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char symbol = ' ';
            int nCounter = 0;
            int cCounter = 0;
            int oCounter = 0;
            string text = "";
            while (input != "End")
            {
                symbol = char.Parse(input);
                switch (symbol)
                {
                    case 'n':
                        nCounter++;
                        break;
                    case 'c':
                        cCounter++;
                        break;
                    case 'o':
                        oCounter++;
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine();
            text += symbol;
            }
            Console.WriteLine(text);
        }
    }
}
