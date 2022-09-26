using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_Exercises
{
    public static class CamelCase
    {
        /* 
            Exercise URL
            https://www.hackerrank.com/challenges/camelcase/problem?isFullScreen=true


            Console.WriteLine(camelcaseBetterSolution("oneTwoThree"));
        */
        public static int camelcase(string s)
        {
            int counter = 0;
            foreach (var character in s)
            {
                if (Char.IsUpper(character))
                    counter++;
            }
            return counter + 1;
        }

        public static int camelcaseBetterSolution(string s)
        {
            // 65
            // 90
            int counter = 0;
            foreach (var character in s)
            {
                if ((int)character >= 65 && (int)character <= 90)
                    counter++;
            }
            return counter + 1;
        }
    }
}
