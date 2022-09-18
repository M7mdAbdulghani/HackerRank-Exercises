using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_Exercises
{
    public static class AppleAndOrange
    {
        /* 
            Exercise URL
            https://www.hackerrank.com/challenges/apple-and-orange/problem?isFullScreen=true

            int s = 7;
            int t = 10;
            int a = 4;
            int b = 12;

            var apples = new List<int>();
            apples.Add(2);
            apples.Add(3);
            apples.Add(-4);

            var oranges = new List<int>();
            oranges.Add(3);
            oranges.Add(-2);
            oranges.Add(-4);

            countApplesAndOranges(s, t, a, b, apples, oranges);
        */

        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int applesCount = 0;
            int orangesCount = 0;
            foreach (var apple in apples)
            {
                applesCount += ((apple + a) >= s && (apple + a) <= t) ? 1 : 0;
            }

            foreach (var orange in oranges)
            {
                orangesCount += ((orange + b) >= s && (orange + b) <= t) ? 1 : 0;
            }

            Console.WriteLine(applesCount);
            Console.WriteLine(orangesCount);
        }
    }
}
