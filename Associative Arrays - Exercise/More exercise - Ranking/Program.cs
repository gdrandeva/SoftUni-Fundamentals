using System;
using System.Collections.Generic;
using System.Linq;

namespace More_exercise___Ranking
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            

            Dictionary<string, string> typeOfContest = new Dictionary<string, string>();
            Dictionary<string, string> forValidation = new Dictionary<string, string>();
            Dictionary<string, List<int>> studentsDictionaries = new Dictionary<string, List<int>>();
           

            while (input != "end of contests")
            {
                string[] contest = input.Split(':');
                string typeOfContestKey = contest[0];
                string typeOfContestValue = contest[1];

                typeOfContest.Add(typeOfContestKey, typeOfContestValue);

                input = Console.ReadLine();

            }
            string secondInput = Console.ReadLine();

            while (secondInput!= "end of submissions")
            {
                string[] contestByUser = secondInput.Split("=>");
                string exam = contestByUser[0];
                string password = contestByUser[1];
                string student = contestByUser[2];
                int points = int.Parse(contestByUser[3]);

                if (typeOfContest.ContainsKey(exam))
                {
                    if (typeOfContest.Values[password]==forValidation.Values[password])
                    {
                        forValidation.Add(exam, password);

                        studentsDictionaries.Add(student, new List<int>());
                        studentsDictionaries[student].Add(points);
                    }
                }
                else
                {
                    secondInput = Console.ReadLine();
                    continue;
                }
                secondInput = Console.ReadLine();
            }
        }

        

    }
}
