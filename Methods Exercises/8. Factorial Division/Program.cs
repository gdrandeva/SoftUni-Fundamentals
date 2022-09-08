using System;

namespace _8._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            double result1 = Factorial(num1);
            double result2 = Factorial(num2);
            Console.WriteLine($"{result1/result2:f2}");
        }

        static double Factorial(int number)
        {
            double result = 1;

            while (number!=1)
            {
                result *= number;
                number--;
            }
            return result;
        }


        //static void Main(string[] args)
        //{
        //    int firstNum = int.Parse(Console.ReadLine());
        //    int secondNum = int.Parse(Console.ReadLine());

        //    int factorialOfFirst = CalculateFactorial(firstNum);
        //    int factorialOfSecond = CalculateFactorial(secondNum);
        //    DivisionResult(factorialOfFirst, factorialOfSecond);

        //}


        //static int CalculateFactorial(int number)
        //{
        //    int factorial = 1;
        //    while (number != 1)
        //    {
        //        factorial *= number;
        //        number--;
        //    }
        //    return factorial;
        //}
        //static void DivisionResult(double factorialOfFirst, double factorialOfSecond)
        //{
        //    Console.WriteLine($"{factorialOfFirst / factorialOfSecond:f2}");
        //}
    }
}
