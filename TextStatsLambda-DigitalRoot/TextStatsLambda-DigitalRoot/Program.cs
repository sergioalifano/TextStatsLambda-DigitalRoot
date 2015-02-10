using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStatsLambda_DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int DigitalRoot(string rootThisNumber)
        {
            int number;
            int sum = 0;

            //LAMBDA EXPRESSION
        /*    while (rootThisNumber.Length > 1)
            {
                sum = rootThisNumber.Sum(x => int.Parse(x.ToString()));
                rootThisNumber = sum.ToString();
            }
            return sum;
        */

            //check if it's a valid input
            if (int.TryParse(rootThisNumber, out number))
            {
                //loop until it's a single digit
                while (rootThisNumber.Length > 1)
                {
                    //loop through the string 
                    foreach (char digit in rootThisNumber)
                    {
                        //sum the digits of the number
                        sum += int.Parse(digit.ToString());
                    }
                    
                    rootThisNumber = sum.ToString();
                    sum = 0;
                }
            }

            return int.Parse(rootThisNumber);
        }

        public static int NumberOfWords(string inputString)
        {

            return inputString.Split().Count();
        }

        public static int NumberOfVowels(string inputString)
        {

            return inputString.Count(x => "aeiou".Contains(char.ToLower(x)));
        }

        public static int NumberOfConsonants(string inputString)
        {

           return inputString.Count(x => "bcdfghjklmnpqrstvwxyz".Contains(char.ToLower(x)));
           
        }

        public static int NumberOfSpecialCharacters(string inputString)
        {
            // .,?;'!@#$%^&*() and spaces are considered special characters
            return inputString.Count(x => ".,?;'!@#$%^&*() ".Contains(char.ToLower(x)));
        }

        public static string LongestWord(string inputString)
        {

            return inputString.Split().OrderBy(x => x.Length).Last();
        }

        public static string ShortestWord(string inputString)
        {
            return inputString.Split().OrderBy(x => x.Length).First();
        }


    }
}
