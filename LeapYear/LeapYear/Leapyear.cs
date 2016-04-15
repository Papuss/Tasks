using System;

namespace DojoLeapYear
{
    public class Leapyear
    {
        static void Main(string[] args)
        {

            
        }

        public static bool IsLeapYear(int year)
        {
            if (!(year >= 0))
            {
                throw new ArgumentException();
            }
            return ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0));

        }
    }
}
