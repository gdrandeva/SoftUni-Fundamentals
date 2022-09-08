using System;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isPasswordLengthValid = ValidatePasswordLength(password);
            bool isPasswordContainsOnlyLettersAndDigits = ValidatePasswordContent(password);
            bool isPasswordHasTwoDigits = ValidateNumberOfDigits(password);

            if (!isPasswordLengthValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isPasswordContainsOnlyLettersAndDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!isPasswordHasTwoDigits)
            {

                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isPasswordContainsOnlyLettersAndDigits && isPasswordHasTwoDigits && isPasswordLengthValid)
            {
                Console.WriteLine("Password is valid");
            }

        }

        static bool ValidateNumberOfDigits(string password)
        {
            int count = 0;
            foreach (char symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    count++;
                }
            }
            return count >= 2;

        }


        static bool ValidatePasswordContent(string password)
        {
            foreach (char symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }

            }
            return true;
        }
        static bool ValidatePasswordLength(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }


    }
}