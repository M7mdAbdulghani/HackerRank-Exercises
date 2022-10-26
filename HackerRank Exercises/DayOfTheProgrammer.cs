using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_Exercises
{
    public class DayOfTheProgrammer
    {
        /* 
            Exercise URL
            https://www.hackerrank.com/challenges/day-of-the-programmer/problem

            Console.WriteLine(dayOfProgrammer(1918));
            Console.WriteLine(dayOfProgrammer(1800));
            Console.WriteLine(dayOfProgrammer(2016));
            Console.WriteLine(dayOfProgrammer(2017));
        */
        public static string dayOfProgrammer(int year)
        {
            var gregorianCalendar = false;
            var day = 13;
            if (year < 1700 || year > 2700)
                return "Not Valid Value";

            if (year > 1918)
                gregorianCalendar = true;


            if (year == 1918)
                day = 26;
            if (gregorianCalendar && ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)))
                day = 12;
            if (!gregorianCalendar && year % 4 == 0)
                day = 12;

            return day + ".09" + "." + year;
        }
    }
}
