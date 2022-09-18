using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_Exercises
{
    public static class LibraryFine
    {
        /* 
            Exercise URL
            https://www.hackerrank.com/challenges/library-fine/problem?isFullScreen=true

            int d1 = 9;
            int m1 = 6;
            int y1 = 2015;

            // Due
            int d2 = 6;
            int m2 = 6;
            int y2 = 2015;

            Console.WriteLine(libraryFine(d1, m1, y1, d2, m2, y2));
        */


        public static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            if (y1 > y2)
            {
                return 10000;
            }

            else
            {
                if (y1 == y2 && m1 > m2)
                {
                    return 500 * (m1 - m2);
                }
                else if (y1 == y2 && m2 == m1 && d1 > d2)
                {
                    return 15 * (d1 - d2);
                }
                else
                {
                    return 0;
                }
            }
        }

        public static int libraryFineOptimized(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            if (y1 > y2)
            {
                return 10000;
            }

            if (y1 == y2 && m1 > m2)
            {
                return 500 * (m1 - m2);
            }

            if (y1 == y2 && m2 == m1 && d1 > d2)
            {
                return 15 * (d1 - d2);
            }

            return 0;
        }
    }
}
