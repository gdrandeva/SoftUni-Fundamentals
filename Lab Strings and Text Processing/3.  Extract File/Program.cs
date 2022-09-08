using System;

namespace _3.__Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            //char[] separators = new char[] {':', '\\', '-', '.' };
            //string[] filePath = Console.ReadLine().Split(separators,StringSplitOptions.RemoveEmptyEntries);

            //string fileName = filePath[filePath.Length - 2];
            //string extension = filePath[filePath.Length - 1];
            //Console.WriteLine($"File name: {fileName}");
            //Console.WriteLine($"File extension: {extension}");


            
            string[] filePath = Console.ReadLine().Split('\\', StringSplitOptions.RemoveEmptyEntries);
            string[] file = filePath[filePath.Length - 1].Split('.');
            string fileName = file[0];
            string extension = file[1];
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");


        }
    }
}
