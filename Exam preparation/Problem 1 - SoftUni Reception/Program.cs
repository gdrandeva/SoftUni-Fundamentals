using System;

namespace Problem_1___SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeeEfficiencyPerHour=int.Parse(Console.ReadLine());
            int secondEmployeeEfficiencyPerHour = int.Parse(Console.ReadLine());
            int thirdEmployeeEfficiencyPerHour = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            int hour = 0;
            int allEmployeesPerHour = firstEmployeeEfficiencyPerHour + secondEmployeeEfficiencyPerHour + thirdEmployeeEfficiencyPerHour;
            

            for (int i = 1; i <= 24; i++)
            {
                hour++;
                if (i%4==0)
                {
                    continue;
                }
                studentsCount -=  allEmployeesPerHour;
                
                if (studentsCount <= 0)
                {
                    break; 
                    
                }
                else if (studentsCount>0)
                {
                    continue;
                }
            }

            Console.WriteLine($"Time needed: {hour}h.");

        }
    }
}
