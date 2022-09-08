using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_2___Mirror_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string barcodePattern = @"@#+[A-Z][a-zA-Z\d]{4,}[A-Z]@#";

            int numberOfBarcodesToReceive = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfBarcodesToReceive; i++)
            {
                string currentBarcode = Console.ReadLine();

                if (Regex.IsMatch(currentBarcode, barcodePattern))
                {
                    char[] digits = currentBarcode.Where(char.IsDigit).ToArray();

                    string barcodeGroup = digits.Length == 0 ? "00" : string.Join("", digits);
                    Console.WriteLine($"Product group: {barcodeGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
