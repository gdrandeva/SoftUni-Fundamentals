using System;

namespace _8._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());

            string result = RepeatString(input,times);
            Console.WriteLine(RepeatString(input, times));
        }
        static string RepeatString(string input, int times)
        {
            string result = string.Empty;
            for (int i = 0; i < times; i++)
            {
                result = result + input;
            }
            return result;
        }


        //static void Main()
        //{
        //    string input = Console.ReadLine();
        //    int numOfRepeats = int.Parse(Console.ReadLine());

        //    Console.WriteLine(RepeatString(input, numOfRepeats));
        //}

        //static string RepeatString(string input, int numOfRepeats)
        //{
        //    string result = "";
        //    for (int i = 1; i <= numOfRepeats; i++)
        //    {
        //        result += input;
        //    }
        //    return result;
        //}
    }
}
