using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_Exercises
{
    public static class ElectronicsShop
    {
        /* 
            Exercise URL
            https://www.hackerrank.com/challenges/electronics-shop/problem?isFullScreen=true

            Console.WriteLine(getMoneySpent(new int[] { 40, 50, 60 }, new int[] { 5, 8, 12 }, 60));
        */
        public static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            /*
             * Write your code here.
             */
            int max = 0;

            foreach (var drive in drives)
            {
                foreach (var keyboard in keyboards)
                {
                    if (drive + keyboard <= b && drive + keyboard > max)
                        max = drive + keyboard;
                }
            }

            return max == 0 ? -1 : max;
        }
    }
}
