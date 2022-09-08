using System;

namespace _3._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int result = 0;

            switch (action)
            {
                case "add":
                    AddCalculation(firstNumber, secondNumber);
                    break;
                case "multiply":
                    MultiplyCalculation(firstNumber, secondNumber);
                    break;
                case "substract":
                    SubstractCalculation(firstNumber, secondNumber);
                    break;
                case "divide":
                    DivideCalculation(firstNumber, secondNumber);
                    break;
            }


        }
        static void AddCalculation(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber+secondNumber);

        }
        static void MultiplyCalculation(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber*secondNumber); 
            
        }
        static void SubstractCalculation(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber-secondNumber);
        }
        static void DivideCalculation(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber/secondNumber);
        }


    }
}

