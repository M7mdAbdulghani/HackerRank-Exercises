using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_Exercises
{
    public class SaveThePrisoner
    {
        /* 
            Exercise URL
            https://www.hackerrank.com/challenges/save-the-prisoner/problem?isFullScreen=true


            Console.WriteLine(saveThePrisoner(7, 19, 2));
            Console.WriteLine(saveThePrisoner(3, 7, 3));
            Console.WriteLine(saveThePrisoner(208526924, 756265725, 150817879));
            Console.WriteLine(saveThePrisoner(4, 4, 1));
            Console.WriteLine(saveThePrisoner(10, 3, 9));
            Console.WriteLine(saveThePrisoner(999999999, 999999999, 2));
        */
        public static int saveThePrisoner(int n, int m, int s)
        {
            if (((m % n) + (s - 1)) <= n && ((m % n) + (s - 1)) >= 1)
                return ((m % n) + (s - 1));
            if (((m % n) + (s - 1)) < 1)
                return ((m % n) + (s - 1)) + n;
            else
                return ((m % n) + (s - 1)) % n;
        }

        public static int saveThePrisonerEnhanced(int n, int m, int s)
        {
            var prisoner = (m + s - 1) % n;
            if (prisoner == 0)
                prisoner = n;
            return prisoner;
        }
    }
}
