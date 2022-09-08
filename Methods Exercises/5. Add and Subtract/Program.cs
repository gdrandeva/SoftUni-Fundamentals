using System;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int addProduct = AddProductSum(firstNum, secondNum);

            int substractionResult = SubstractThirdfromSum(addProduct, thirdNum);
            Console.WriteLine(substractionResult);

        }


        static int AddProductSum(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
        static int SubstractThirdfromSum(int addProduct, int thirdNum)
        {
            return addProduct - thirdNum;
        }
    }
}