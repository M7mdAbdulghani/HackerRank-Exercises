using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_Exercises
{
    public static class StairCase
    {
        /* 
            Exercise URL
            https://www.hackerrank.com/challenges/staircase/problem?isFullScreen=true

            staircase(6);
            staircase(10);
        */
        public static void staircase(int n)
        {
            int counter = 10;
            for (int i = 1; i <= counter; i++)
            {
                for (int j = 1; j <= counter - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = counter; k > counter - i; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
