using System;

namespace _9._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "string":
                    string firstValue = Console.ReadLine();
                    string secondValue = Console.ReadLine();
                    Console.WriteLine(GetMaxValue(firstValue, secondValue));
                    break;
                case "int":
                    int firstValueInt = int.Parse(Console.ReadLine());
                    int secondValueInt = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMaxValue(firstValueInt, secondValueInt));
                    break;
                case "char":
                    char firstValueChar = char.Parse(Console.ReadLine());
                    char secondValueChar = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMaxValue(firstValueChar, secondValueChar));
                    break;
                
            }
            
            

        }

        static string GetMaxValue(string firstValue, string secondValue)
        {
            int result=firstValue.CompareTo(secondValue);
            if (result>0)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }
        }

        static int GetMaxValue(int firstValue, int secondValue)
        {
            if (firstValue > secondValue)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }
        }

        static char GetMaxValue(char firstValue, char secondValue)
        {
            if (firstValue > secondValue)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }
        }
    }
}
