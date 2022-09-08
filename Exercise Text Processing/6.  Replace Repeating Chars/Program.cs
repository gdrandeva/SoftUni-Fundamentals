using System;
using System.Text;

namespace _6.__Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < text.Length-1; i++)
            {
                if (text[i]!= text[i+1])
                {

                    sb.Append(text[i]);
                }
                
            }
            if (!sb.ToString().Contains(text[text.Length-1]))
            {
                sb.Append(text[text.Length - 1]);
            }
            if (sb.ToString().LastIndexOf(text))
            {
                sb.Append(text[text.Length - 2]);
            }
            
            Console.WriteLine(sb);
        }
    }
}
