using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers) 
       {
            var sum = 0;

            foreach (var item in numbers)
            {

                if (item % 2 == 0)
                {
                    sum += item;
                }
                if (item % 2 != 0)
                {
                    sum -= item;
                }

            }
            return sum;
        }

         public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
         {
            var head = str1.Length;

            return  str2.Length < head ? str2.Length : str3.Length < head ? str3.Length : str4.Length < head ? str4.Length : head;

         }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int> { number1, number2, number3, number4 };
            return list.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
           biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 && sideLength1 + sideLength3 > sideLength2)
            {
                return true;
            }
            return false;
        }

        public bool IsStringANumber(string input) => double.TryParse(input, out double number);
       

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
             var amount = objs.Length;
             var marjority = (amount / 2) + 1;

             var count = 0;

             foreach (var obj in objs)
             {
                if (obj == null)
                {
                    count++;
                }
                if (count >= marjority)
                {
                    return true;
                }
               
             }
            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            double sum = 0;
            double count = 0;

            if (numbers == null)
            {
                return 0;
            }
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                     
                }
            }

            if (count > 0 )
            {
                return sum / count;
            }
            else
            {
                return 0;
            }
        }

        public int Factorial(int number)
        {
            var fact = 1;

            for (int i = 0; i > 0; i++)
            {
               fact *= i;
            }

            return fact;
        }
    }
}
