using System;
using System.Text;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder explosionedStr = new StringBuilder(Console.ReadLine());
            int strenght = 0;

            for (int i = 0; i < explosionedStr.Length-1; i++)
            {
                char current = explosionedStr[i];
                if (current == '>')
                {
                    strenght += int.Parse(explosionedStr[i+1].ToString());
                    string substring = explosionedStr.ToString().Substring(i + 1,strenght);
                    if (strenght>1 && (!substring.Contains('>')))
                    {
                        explosionedStr.Remove(i + 1, strenght);
                        strenght = 0;
                        i += strenght;
                        continue;
                    }
                    else if (strenght > 1 && substring.Contains('>'))
                    {
                       
                        explosionedStr.Remove(i + 1, 1);
                        strenght--;
                        if (explosionedStr[i+1]=='>')
                        {
                            
                            continue;
                            
                        }
                    }

                    
                    explosionedStr.Remove(i + 1, 1);
                    strenght--;
                }
            }



            Console.WriteLine(explosionedStr);

        }
    }
}
