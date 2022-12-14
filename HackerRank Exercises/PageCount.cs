using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_Exercises
{
    public class PageCount
    {
        /* 
            Exercise URL
            https://www.hackerrank.com/challenges/drawing-book/problem


            Console.WriteLine(pageCount(6, 2));   
            Console.WriteLine(pageCount(5, 4)); 
            Console.WriteLine(pageCount(83246, 78132));
        */
        public static int pageCount(int n, int p)
        {
            int backCount = 0;
            int frontCount = 0;

            // First Loop (Start)
            for (int i = 1; i <= n; i = i + 2)
            {
                if (p <= i)
                    break;
                frontCount++;
            }
            // Second Loop (End)
            for (int i = (n % 2 == 0) ? n : n - 1; i >= 1; i = i - 2)
            {
                if (p >= i)
                    break;
                backCount++;
            }

            return (frontCount > backCount) ? backCount : frontCount;
        }

        public static int pageCountEnhanced(int n, int p)
        {
            if (n % 2 == 0)
            {
                return (p / 2) < ((n - p + 1) / 2) ? (p / 2) : ((n - p + 1) / 2);
            }
            return (p / 2) < ((n - p) / 2) ? (p / 2) : ((n - p) / 2);
        }
    }
}
