using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_Exercises
{
    public static class TimeConversion
    {
        /* 
            Exercise URL
            https://www.hackerrank.com/challenges/time-conversion/problem?isFullScreen=true

            string time = "12:01:00PM";
            string time = "07:05:45PM";

        */
        public static string timeConversion(string s)
        {
            string timeResult = "";
            bool isMorning = s.ToLower().Contains("am") ? true : false;
            string hour = s.Substring(0, 2);
            string timeRestCharacters = s.Substring(s.IndexOf(':')).Replace("AM", "").Replace("PM", "");
            int hourInNumbers = int.Parse(hour);


            if (isMorning)
            {
                timeResult = hour == "12" ? "00" : hour;
            }
            else
            {
                timeResult = hour == "12" ? hour : (hourInNumbers + 12).ToString();
            }

            return timeResult + timeRestCharacters;
        }
    }
}
