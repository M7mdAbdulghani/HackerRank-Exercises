using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_Exercises
{
    public class The_Hurdle_Race
    {
        /* 
            Exercise URL
            https://www.hackerrank.com/challenges/the-hurdle-race/problem?isFullScreen=true

            Console.WriteLine(hurdleRace(7, new List<int> { 2, 5, 4, 5, 2 }));
        */
        public static int hurdleRace(int k, List<int> height)
        {
            int max = 0;
            for (int i = 0; i < height.Count; i++)
            {
                if (height[i] > max)
                    max = height[i];
            }

            return k >= max ? 0 : max - k;
        }
    }
}
