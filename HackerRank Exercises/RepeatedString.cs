using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank_Exercises
{
    public static class RepeatedString
    {
        /* 
            Exercise URL
            https://www.hackerrank.com/challenges/repeated-string/problem?isFullScreen=true


            Console.WriteLine(repeatedString("abcac", 10));
            Console.WriteLine(repeatedString("abcac", 20));
        */
        public static long repeatedString(string s, long n)
        {
            // abcac --> 10
            int stringLength = s.Length;
            int countForFirstPart = 0;
            long result;
            for (int i = 0; i < stringLength; i++)
            {
                if (s[i] == 'a')
                    countForFirstPart++;
            }

            result = countForFirstPart * (n / stringLength);

            for (int i = 0; i < (n % stringLength); i++)
            {
                if (s[i] == 'a')
                    result++;
            }
            return result;
        }

        public static long repeatedStringUsingLinq(string s, long n)
        {
            int stringLength = s.Length;
            long result;

            int countForFirstPart = s.Count(c => c == 'a');

            result = countForFirstPart * (n / stringLength);
            result += (int)(n % stringLength) == 0 ? 0
                                    : (int)(n % stringLength) < stringLength ? s.Substring(0, (int)(n % stringLength)).Count(c => c == 'a')
                                    : s.Substring((int)(n % stringLength)).Count(c => c == 'a');
            return result;
        }


        // Simple And Elegant Solution
        public static long repeatedStringEnhanced(string s, long n)
        {
            int stringLength = s.Length;
            long remainingString = (n % stringLength);
            int countForFirstPart = getCount(stringLength, s, 0);


            return (countForFirstPart * (n / stringLength)) + getCount((int)remainingString, s, 0);
        }
        public static int getCount(int stringLength, string s, int count)
        {
            for (int i = 0; i < stringLength; i++)
            {
                if (s[i] == 'a')
                    count++;
            }
            return count;
        }
    }
}
