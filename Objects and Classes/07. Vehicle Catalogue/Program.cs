using System;
using System.Collections.Generic;

namespace _07._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input!="end")
            {
                string[] command = input.Split('/');

                switch (command[0])
                {
                    case "Car":
                        Car car = new Car();
                        car.Brand = command[1];
                        car.Model = command[2];
                        car.HorsePower = int.Parse(command[3]);

                        Catalog cars = new Catalog();
                        cars.Cars.Add(command[1]);
                       


                        break;
                    case "Truck":
                        Truck truck = new Truck();
                        truck.Brand = command[1];
                        truck.Model = command[2];
                        truck.Weight = int.Parse(command[3]);
                           
                        break;
                    default:
                        break;
                }



                input = Console.ReadLine();

            }
        }
    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    class Catalog
    {
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
