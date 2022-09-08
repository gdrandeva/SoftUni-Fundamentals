using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog john = new Dog();
            john.Name = "John";
            john.Breed = "pudel";
            john.Age = 6;
            john.Weight = 12.4;

            Dog maria = new Dog();
            maria.Name = "Maria";
            maria.Breed = "JR";
            maria.Age = 2;
            maria.Weight = 5.3;

            Console.WriteLine();
        }
    }

    class Dog
    { 
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
    }
}
