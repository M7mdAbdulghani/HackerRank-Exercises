using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_Exercises
{
    public static class CountingValleys
    {
        /* 
            Exercise URL
            https://www.hackerrank.com/challenges/counting-valleys/problem?isFullScreen=true

            Console.WriteLine(countingValleys(8, "DDUUDDUDUUUD"));
        */
        public static int countingValleys(int steps, string path)
        {
            int count = 0;
            int downActualCount = 0;
            int result = 0;

            foreach (var character in path)
            {
                count = character == 'U' ? count += 1 : count -= 1;

                if (count < 0)
                    downActualCount--;

                if (count == 0 && downActualCount < 0)
                {
                    downActualCount = 0;
                    result++;
                }
            }
            return result;
        }

        public static int countingValleysInhanced(int steps, string path)
        {
            int count = 0;
            int result = 0;
            foreach (var character in path)
            {
                count = (character == 'U') ? count += 1 : count -= 1;
                if (count == 0 && character == 'U')
                    result++;
            }
            return result;
        }
    }
}
