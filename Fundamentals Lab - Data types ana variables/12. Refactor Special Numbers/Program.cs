using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= count; i++)
            {
                int currentNum = 0;
                currentNum = i;
                int sum = 0;
                while (currentNum > 0)
                {
                    
                    sum += currentNum % 10;
                    currentNum /=  10;
                }
                bool isSpecialNum = false;
                isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{currentNum} -> {isSpecialNum}");
                
            }

        }
    }
}


