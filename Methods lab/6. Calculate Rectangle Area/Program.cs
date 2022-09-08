using System;

namespace _6._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = CalculateArea(width,height);
            Console.WriteLine(area);
        }

        static double CalculateArea(double width, double height)
        {
            double area = width * height;

            return area;
        }



        //static void Main(string[] args)
        //{
        //    int length = int.Parse(Console.ReadLine());
        //    int width = int.Parse(Console.ReadLine());

        //    //int area = RectangleArea(length, width);
        //    Console.WriteLine(RectangleArea(length, width));
        //}

        //static int RectangleArea(int length, int width)
        //{

        //    return length * width;
        //}

    }
}
