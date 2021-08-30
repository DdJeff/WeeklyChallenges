using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals) =>  vals.Contains(false);
        

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers) => numbers == null ? false :  numbers.Sum() % 2 != 0;


        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            
           //initialize checker vars  
            bool checkUpper = false;
            bool checkLower = false;
            bool checkDigit = false;

            //looing through string checking for case and digit
            for (int i = 0; i < password.Length; i++) { 
           
                if (char.IsDigit(password[i]))
                {
                    checkDigit = true;

                }
                if (char.IsUpper(password[i]))
                {
                    checkUpper = true;
                }
                if (char.IsLower(password[i]))
                {
                    checkLower = true;
                }

        
            }

            if (checkDigit && checkUpper && checkLower)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public char GetFirstLetterOfString(string val) => val[0];

        public char GetLastLetterOfString(string val) => val[val.Length -1];


        public decimal Divide(decimal dividend, decimal divisor) => divisor == 0 ? 0 : dividend /divisor ;


        public int LastMinusFirst(int[] nums) => nums[nums.Length - 1] - nums[0];
       

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    odds.Add(i);
                }
            }

            return odds.ToArray();
            
        }

        public void ChangeAllElementsToUppercase(string[] words) 
        {

            for (int i = 0; i < words.Length; i++)
            {
                
                Console.WriteLine(words[i] = words[i].ToUpper());
            }
            
        }
    }
}
