using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank_Exercises
{
    public static class FindDigits
    {
        /* 
            Exercise URL
            https://www.hackerrank.com/challenges/find-digits/problem?isFullScreen=true


            Console.WriteLine(findDigits(106108048)); // Should be 5
        */
        public static int findDigits(int n)
        {
            int original = n;
            int count = 0;
            while (n != 0)
            {
                int number = n % 10;
                if (number == 0)
                {
                    n /= 10;
                    continue;
                }

                count = (original % number == 0) ? count += 1 : count;
                n /= 10;
            }
            return count;
        }

        public static int findDigitsMuchReadable(int n)
        {
            int original = n;
            int count = 0;
            while (n != 0)
            {
                int number = n % 10;
                if (number != 0)
                {
                    count = (original % number == 0) ? count += 1 : count;
                }
                n /= 10;
            }
            return count;
        }

        public static int findDigitsUsingLinq(int n)
        {
            return n.ToString().Count(c => int.Parse(c.ToString()) != 0 && n % int.Parse(c.ToString()) == 0);
        }
    }
}
