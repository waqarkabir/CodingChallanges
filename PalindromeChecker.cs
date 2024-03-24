using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallanges
{
    public class PalindromeChecker
    {
        public static string Check(string text)
        {
            string reverseString = ReverseString(text);

            if (IsPalindrome(text, reverseString))
            {
                return $"{text} is a palindrome";
            }
            else
            {
                return $"{text} is not a palindrome";
            }
        }

        public static bool IsPalindrome(string first, string second) 
        {
            return first.Equals(second);
        }

        public static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray);
        }

    }
}
