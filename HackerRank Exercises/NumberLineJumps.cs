using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_Exercises
{
    public static class NumberLineJumps
    {
        /* 
            Exercise URL
            https://www.hackerrank.com/challenges/kangaroo/problem?isFullScreen=true

            int x1 = 43;
            int v1 = 2;

            int x2 = 70;
            int v2 = 2;

            Console.WriteLine(kangaroo(x1, v1, x2, v2));
        */

        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            for (var i = 0; i <= 10000; i++)
            {
                if ((x1 + v1) == (x2 + v2))
                {
                    return "YES";
                }
                x1 += v1;
                x2 += v2;
            }
            return "NO";
        }
    }
}
