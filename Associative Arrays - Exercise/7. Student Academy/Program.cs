using System;
using System.Linq;
using System.Collections.Generic;

namespace _7._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> dictionaryOfStudent = new Dictionary<string, List<double>>();
            

            for (int i = 0; i < studentsCount ; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (! dictionaryOfStudent.ContainsKey(studentName))
                {
                    dictionaryOfStudent[studentName] = new List<double>();
                }
                dictionaryOfStudent[studentName].Add(studentGrade);
               
                

            }
            foreach (var item in dictionaryOfStudent)
            {
                string name = item.Key;
                var averageGrade = item.Value.Average();
                
                if (averageGrade >= 4.50)
                {
                    Console.WriteLine($"{name} -> {averageGrade:f2}");
                }

            }
           
            
        }
    }
}
