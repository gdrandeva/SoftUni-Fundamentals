using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            List<int> possibleTopNums = new List<int>();
            possibleTopNums = DivisibleByEight(number, sum, possibleTopNums);
            possibleTopNums = AtLeastOneOddDigit(number,possibleTopNums);
            foreach (var item in possibleTopNums)
            {
                Console.WriteLine(item);
            }
        }

        static List<int> AtLeastOneOddDigit(int number, List<int> possibleTopNums)
        {
            for (int k = 0; k < possibleTopNums.Count; k++)
            {
                int count = 0;
                string numAsStr = possibleTopNums[k].ToString();
                for (int i = 0; i < numAsStr.Length; i++)
                {
                    if (numAsStr[i] %2== 0)
                    {
                        count++;
                        if (count >= 1)
                        {
                            possibleTopNums.Remove(possibleTopNums[k]);
                            k--;
                            break; 
                        }
                    }
                }
            }

            return possibleTopNums;
        }

        static List<int> DivisibleByEight(int number, int sum, List<int> possibleTopNums)
        {
            for (int i = 8; i <= number; i++)
            {
                string currChar = i.ToString();
               

                
                    for (int j = 0; j < currChar.Length; j++)
                    {
                    if ((currChar[j] >= '0') && (currChar[j] <= '9'))
                    {
                        sum += int.Parse(currChar[j].ToString());
                        continue;
                    }
                }
                

                if (sum % 8 == 0)
                {
                   possibleTopNums.Add(int.Parse((currChar).ToString()));
                }
                sum = 0;
            }
            return possibleTopNums;
        }
    }
}


//using System;

//namespace TopNumber
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string endRange = Console.ReadLine();

//            TopNumber(endRange);
//        }

//        static void TopNumber(string endRange)
//        {
//            int number = int.Parse(endRange);

//            for (int i = 0; i < number; i++)
//            {
//                bool OddDigit = false;
//                int currentNumber = i;
//                int sum = 0;

//                while (currentNumber != 0)
//                {
//                    int digit = currentNumber % 10;
//                    sum += digit;

//                    if (digit % 2 != 0)
//                    {
//                        OddDigit = true;
//                    }

//                    currentNumber /= 10;
//                }

//                if (OddDigit && (sum % 8 == 0))
//                {
//                    Console.WriteLine(i);
//                }
//            }
//        }
//    }
//}
