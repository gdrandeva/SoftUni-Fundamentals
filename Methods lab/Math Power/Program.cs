using System;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseNum = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            
            

            Console.WriteLine(CalculationBaseRaisedToPower(baseNum,power));
        }

        static double CalculationBaseRaisedToPower(double baseNum, double power)
        {
            double raisedNumber = 1;
            for (int i = 1; i <= power; i++)
            {
                raisedNumber *= baseNum;
            }
            return raisedNumber;
        }
    }
}
