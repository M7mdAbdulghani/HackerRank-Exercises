using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_Exercises
{
    public static class UtopianTree
    {
        /* 
            Exercise URL
            https://www.hackerrank.com/challenges/utopian-tree/problem

            Console.WriteLine(utopianTreeEnhanced(8));
        */
        public static int utopianTree(int n)
        {
            int start = 1;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                    start *= 2;
                else
                    start += 1;
            }
            return start;
        }

        // O(1) Very optimal Solution
        public static int utopianTreeEnhanced(int n)
        {
            // Getting the number first
            int number;
            // Result
            double result;
            if (n % 2 == 0)
            {
                number = (n + 2) / 2;
                result = Math.Pow(2, number) - 1;
            }
            else
            {
                number = (n + 3) / 2;
                result = Math.Pow(2, number) - 2;
            }
            return (int)result;
        }
        // Solved Using Recursion (Nice Solution)
        public static int utopianTreeEnhancedRecursion(int n)
        {
            if (n == 0)
                return 1;
            if (n % 2 == 0)
                return utopianTree(n - 1) + 1;
            else
                return utopianTree(n - 1) * 2;
        }
    }
}
