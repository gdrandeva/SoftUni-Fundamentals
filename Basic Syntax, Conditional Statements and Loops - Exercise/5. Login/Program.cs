using System;

namespace _5._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
           

            for (int i = username.Length-1; i >=0 ; i--)
            {
                password += username[i];
                
            }
            int countOfWrongPass = 0;
            string inputPassword = Console.ReadLine();

            while (password!=inputPassword)
            {
                countOfWrongPass++;
                if (countOfWrongPass > 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
            Console.WriteLine($"Incorrect password. Try again.");
            inputPassword = Console.ReadLine();
            }
            
            if (password==inputPassword)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
