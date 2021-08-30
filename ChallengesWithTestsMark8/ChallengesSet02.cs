using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c) => char.IsLetter(c);



        public bool CountOfElementsIsEven(string[] vals) => vals.Length % 2 == 0 ? true : false;


        public bool IsNumberEven(int number) => number % 2 == 0 ? true : false;

        public bool IsNumberOdd(int num) => num % 2 != 0 ? true : false;


        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {

            if(numbers.Count() == 0 || numbers == null)
            {
                return 0;
            }

            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2) => str1.Length < str2.Length ? str1.Length : str2.Length;



        // public int Sum(int[] numbers) => numbers.Where( x => == null ).Sum(x => x);
        public int Sum(int[] numbers)
        {

            if (numbers == null)
            {
                return 0;
            }
            return numbers.Sum(x => x);
        }

        public int SumEvens(int[] numbers)
        {

            if (numbers == null)
            {
                return 0;
            }
            return numbers.Where(x => x % 2 == 0).Sum(x => x);
        }

        public bool IsSumOdd(List<int> numbers) {

            if (numbers == null)
            {
                return false;
            }

            return numbers.Sum() % 2 != 0;
        
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            //setting it to one becasue 1 % 2 will be less then 0 and will not count 1

            if (number < 0)
            {
                return 0;
            }
            else
            {
                return number / 2;
                    
            }

          
        }
    
    }
}
