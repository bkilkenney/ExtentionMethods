using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    public static class StringExtentions
    {
        private static Random random = new Random();
        public static string ToRandomCase(this string text)
        {
            string result = "";

            for(int index = 0; index < text.Length; index++)
            {
                if(random.Next(2) == 0) //Picks a random number between 0 and 1. If it's 0 upper, if it's 1 lower case it
                {
                    result += text.Substring(index, 1).ToUpper();
                }
                else
                {
                    result += text.Substring(index, 1).ToLower();
                }
            }
            return result;
        }

        public static string Reverse(this string input)
        {
            return new string(input.ToCharArray().Reverse().ToArray());
        }

        public static void CountWords(this string wordsIn)
        {
            int wordCount = 0;
            string[] words = wordsIn.Split(' ');
            foreach(string word in words)
            {
                wordCount++;
            }
            Console.WriteLine(wordCount);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string message = "I'm sorry Brad, I can't do that";
            Console.WriteLine(message.ToRandomCase());


            string reversal = "Let's give this a shot";
            Console.WriteLine(reversal.Reverse());


            string counter = "Here is the string I will try to count the words of";
            counter.CountWords();
        }
    }
}
