using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main()
        {
            ///, *, + and -.
            int firstNumber = int.Parse(Console.ReadLine());
            string sign = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());
            double result = 0;

            switch (sign)
            {
                case "+":
                    result = Collection(firstNumber, secondNumber);
                    Console.WriteLine(result);
                    break;
                case "-":
                    result = Substraction(firstNumber, secondNumber);
                    Console.WriteLine(result);
                    break;
                case "*":
                    result = Multiplication(firstNumber, secondNumber);
                    Console.WriteLine(result);
                    break;
                case "/":
                    Division(firstNumber,secondNumber,result);
                    break;
               
            }
            
           

        }

        static void Division(int firstNumber, int secondNumber, double result)
        {
            result = firstNumber / secondNumber;
            Console.WriteLine(result);
        }

        static double Multiplication(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        static double Substraction(int firstNumber, int secondNumber)
        {
           return firstNumber - secondNumber;
        }

        static double Collection(int firstNumber, int secondNumber)
        {
            double result = firstNumber + secondNumber;
            return result;
        }
    }
}
