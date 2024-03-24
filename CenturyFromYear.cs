using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallanges
{
    public class CenturyFromYear
    {
        public static string Calculate(int year)
        {
            int result = 0;
            result = (int)year % 100 is 0 ? year / 100 : (year / 100) + 1;
            return string.Concat(result, GetPostfixTextFromNumber(result));
        }

        public static string GetPostfixTextFromNumber(int number)
        {
            //Get the last digit
            int lastDigit = number % 10;

            //Handle Special Case of 11,12,13

            if (number % 100 >= 11 && number % 100 <= 13)
            {
                return "th";
            }

            switch (lastDigit)
            {
                case 1:
                    return "st";
                case 2:
                    return "nd";
                case 3:
                    return "rd";
                default:
                    return "th";
            }
        }
    }
}
