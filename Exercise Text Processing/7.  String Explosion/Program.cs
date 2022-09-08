using System;
using System.Text;

namespace _7.__String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
           
            int strenght = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char currentSymbol = input[i];

                
                if (currentSymbol == '>')
                {
                    sb.Append(currentSymbol);
                    strenght += int.Parse(input[i+1].ToString());
                    
                }
                else if (strenght == 0)
                {
                    sb.Append(currentSymbol);
                    
                }
                else if (strenght != 0)
                {
                    strenght--;
                }

            }
            Console.WriteLine(sb);
        }
    }
}
