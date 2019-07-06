using CDSPractical;
using System;
using System.Collections.Generic;

namespace CDSPracticalMainProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Starting execution
            // Creating object of class check
            Questions chk = new Questions();


            #region ExtractNumbers
            var extractNumbers= chk.ExtractNumbers(new List<string> { "123", "hello", "234" });
            Console.WriteLine("{");
            foreach (var number in extractNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("}");

            #endregion

            #region LongestCommonString
            List<string> firstList=new List<string> {
                "love",
                "wandering",
                "goofy",
                "sweet",
                "mean",
                "show",
                "fade",
                "scissors",
                "shoes",
                "gainful",
                "wind",
                "warn"
            };
        List<string> secondList= new List<string> {
                "wacky",
                "fabulous",
                "arm",
                "rabbit",
                "force",
                "wandering",
                "scissors",
                 "fair",
                 "homely",
                 "wiggly",
                 "thankful",
                 "ear"
             };
            Console.WriteLine(chk.LongestCommonWord(firstList, secondList));
            #endregion

            #region Kilometer to Miles
            Console.WriteLine("Please enter kilometers:");
            double kilometers = Convert.ToDouble(Console.ReadLine());
            double miles = chk.DistanceInMiles(kilometers);
            Console.WriteLine(string.Format("{0:0.00}", miles) + " Miles");
            #endregion

            #region Miles to Kilometer
            Console.WriteLine("Please enter miles:");
            double _miles = Convert.ToDouble(Console.ReadLine());
            double _kilometers = chk.DistanceInKm(_miles);
            Console.WriteLine(string.Format("{0:0.00}", _kilometers) + " Kilometers");
            #endregion

            #region IsPalindrome

            Console.WriteLine("Please enter a word:");
            string word = Convert.ToString(Console.ReadLine());
            bool isPalindrome = chk.IsPalindrome(word);
            if(isPalindrome)
            {
                Console.WriteLine(word + " is a Palindrome"); 
            }
            else
            {
                Console.WriteLine(word + " is not a Palindrome"); 
            }

            #endregion

            #region Shuffle
            var shuffle=chk.Shuffle(new List<string> { "one", "two" });
            Console.WriteLine("{");
            foreach (var item in shuffle)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("}");
            #endregion

            #region Sort
            int[] Array = { 11, 33, 5, -3, 19, 8, 49 };
            var sortedArray = chk.Sort(Array);
            foreach (int sort in sortedArray)
                Console.Write("{0} ", sort);
            #endregion

            Console.ReadLine();
        }
    }
}
