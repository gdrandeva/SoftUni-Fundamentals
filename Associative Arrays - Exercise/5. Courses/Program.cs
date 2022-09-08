using System;
using System.Collections.Generic;

namespace _5._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary <string, List<string>> courses = new Dictionary<string, List<string>>();

            while (input!="end")
            {
                string[] info = input.Split(" : ");
                string course = info[0];
                string student = info[1];

                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string> {});
                    
                    
                }
                
                    courses[course].Add(student);
                


                input = Console.ReadLine();
            }

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                List<string> students = new List<string> {};
                students = course.Value;
                foreach (var student in students)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
