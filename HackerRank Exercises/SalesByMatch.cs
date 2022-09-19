using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_Exercises
{
    public static class SalesByMatch
    {
        /* 
            Exercise URL
            https://www.hackerrank.com/challenges/sock-merchant/problem?isFullScreen=true

            List<int> ar = new List<int>() { 10, 20, 20, 10, 10, 30, 50, 10, 20 };

            Console.WriteLine(sockMerchant(ar.Count, ar)); 
        */
        public static int sockMerchant(int n, List<int> ar)
        {
            int[] occurences = new int[101];
            int counter = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                int number = ar[i];
                occurences[number]++;

                if (occurences[number] == 2)
                {
                    counter++;
                    occurences[number] = 0;
                }
            }
            return counter;
        }
    }
}
