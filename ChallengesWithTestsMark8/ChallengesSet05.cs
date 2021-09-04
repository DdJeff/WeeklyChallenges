using System;
using System.Collections.Generic;
using System.Linq;


namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int num = 0;

          
            //check if the orginal number is % == 0 if so change start number by 1 then

            if (startNumber % n == 0)
            {
                startNumber++;
            }

            //check if startnumber == 0

            if (startNumber == 0)
            {
                return n;
            }

            //loop though the results
            for (int i = startNumber; i < 110; i++)
            {
                if (i % n == 0)
                {
                    num =  i;
                    break;
                }
            }
            return num;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
          

            foreach (var item in businesses)
            {
                if (item.TotalRevenue == 0 )
                {
                    Console.WriteLine(item.Name = "CLOSED"); 
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
           //null check
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

            //check for 1 element
            if (numbers.Length == 1)
            {
                return true;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if ( numbers[i] < numbers[i-1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            //null check
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i-1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            var sentence = "";
            //check if its empty whole arr
            if (words == null || words.Length == 0)
            {
                return "";
            }

            //loop through indexes
            foreach (var word in words)
            {
                if (word.Trim().Length > 0)
                {
                    sentence += word.Trim() + " ";
                }
            }


            if (sentence.Length == 0)
            {
                return "";
            }
         

            return sentence.Trim();
        }
       

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count() == 0)
            {
                return new double[0];
            }

            List<double> everyFourth = new List<double>();

            for (int i = 3; i < elements.Count(); i+=4)
            {
                everyFourth.Add(elements[i]);
            }

            return everyFourth.ToArray();

        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
