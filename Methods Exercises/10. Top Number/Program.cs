using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            int oddCount = 0;
            int currDig = TopNumber(number, sum, oddCount);

        }

        static int TopNumber(int number, int oddCount, int sum)
        {

            int currDig = 0;
            for (int i = 17; i <= number; i++)
            {
                currDig = i;
                string currDigAsStr = currDig.ToString();
                
                if (currDigAsStr.Length > 1)
                {

                    for (int l = 0; l < currDigAsStr.Length - 1; l++)
                    {
                        sum = 0;
                        int firstNum = currDig % 10;
                        if (firstNum%2!=0)
                        {
                            oddCount++;
                        }
                        sum += firstNum;
                        currDig = currDig / 10;
                        sum += currDig;
                        if (sum%8!=0)
                        {
                            continue;
                        }
                        if (currDig % 2 != 0)
                        {
                            oddCount++;
                            if (sum>0 && sum % 8 == 0 && oddCount >= 1)
                            {
                                Console.WriteLine(i);
                            }
                        }

                    }
                }

            }
            return currDig;
        }
    }
}
