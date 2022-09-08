using System;
using System.Linq;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] characterMultipliers = Console.ReadLine().Split();
            string firstString = characterMultipliers[0];
            string secondString = characterMultipliers[1];
            int sum = 0;

            sum = StrMultiplication(firstString,secondString,sum);
            Console.WriteLine(sum);

           
        }

        static int StrMultiplication(string firstString, string secondString, int sum)
        {
            if (firstString.Length == secondString.Length)
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    char firstChar = firstString[i];
                    for (int j = i; j < secondString.Length; j++)
                    {
                        char secondChar = secondString[j];
                        int result = firstChar * secondChar;
                        sum += result;
                        break;
                    }
                }
            }
            else
            {
                string longerStr = string.Empty;
                string shorterStr = string.Empty;
                int differenceCount = 0;
                if (firstString.Length > secondString.Length)
                {
                    longerStr = firstString;
                    shorterStr = secondString;
                }
                else
                {
                    longerStr = secondString;
                    shorterStr = firstString;
                }
                differenceCount = longerStr.Length - shorterStr.Length;
                for (int i = 0; i < shorterStr.Length; i++)
                {

                    char firstChar = firstString[i];
                    for (int j = i; j < longerStr.Length; j++)
                    {
                        char secondChar = secondString[j];
                        int result = firstChar * secondChar;
                        sum += result;
                        break;
                    }
                }
                string additionalElements = longerStr.Substring(longerStr.Length - differenceCount, differenceCount);
                for (int k = 0; k <= additionalElements.Length - 1; k++)
                {
                    sum += additionalElements[k];
                }

            }
            return sum;
        }
    }
}
