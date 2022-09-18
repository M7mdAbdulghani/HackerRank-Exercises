using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_Exercises
{
    public static class DivisibleSumPairs
    {
        /* 
            Exercise URL
            https://www.hackerrank.com/challenges/divisible-sum-pairs/problem?isFullScreen=true

            var ar = new List<int>() { 1, 2, 3, 4, 5, 6 };
            int k = 5;
            Console.WriteLine(divisibleSumPairs(ar.Count, k, ar));
        */

        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int counter = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                int number = ar[i];
                for (int j = 0; j < ar.Count; j++)
                {
                    if (j == i)
                        continue;
                    else if ((number + ar[j]) % k == 0)
                        counter++;
                }
            }
            return counter / 2;
        }
    }
}
