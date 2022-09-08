using System;


namespace Demo
{
    class Program
    {
        static void Main(string[] args) 
        {
            int endValue = int.Parse(Console.ReadLine());
            int[] array = new int[endValue];

            //bool IsItHoldAtLeastOneOddDigit = ContainsOddDigit(endValue);

            for (int i = 1; i <= endValue; i++)
            {

                array[i] = int.Parse(endValue);
            }
           

        }

        

        
    }
}