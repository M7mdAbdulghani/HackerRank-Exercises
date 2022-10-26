using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_Exercises
{
    public static class ViralAdvertising
    {
        /* 
            Exercise URL
            https://www.hackerrank.com/challenges/strange-advertising/problem?isFullScreen=true


            Console.WriteLine(viralAdvertising(5)); // 24
            Console.WriteLine(viralAdvertising(3)); // 9
        */
        public static int viralAdvertising(int n)
        {
            var shared = 5;
            var cumulative = 0;
            for (var i = 0; i < n; i++)
            {
                cumulative += (shared / 2);
                shared = (shared / 2) * 3;
            }
            return cumulative;
        }
    }
}
