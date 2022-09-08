using System;

namespace _7._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintMatrix(n);
        }

        static void PrintMatrix(int n)
        {
            

            for (int rows = 0; rows < n; rows++)
            {
                for (int columns = 0; columns < n; columns++)
                {
                    Console.WriteLine(n+ " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
//using System;
//using System.Linq;

//namespace Demo
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int number = int.Parse(Console.ReadLine());

//            int matrix = PrintMatrix(number);
//        }

//        static int PrintMatrix(int number)
//        {
//            for (int i = 1; i <= number; i++)
//            {
//                for (int j = 1; j <= number; j++)
//                {
//                    Console.Write($"{number} ");

//                }
//                Console.WriteLine();
//            }
//            return number;
//        }
//    }
//}
