using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_Exercises
{
    public static class BirthdayCakeCandles
    {
        /* 
            Exercise URL
            https://www.hackerrank.com/challenges/birthday-cake-candles/problem?isFullScreen=true

            var candles = new List<int>();
            candles.Add(4);
            candles.Add(4);
            candles.Add(1);
            candles.Add(3);

            Console.WriteLine("Count is " + birthdayCakeCandles(candles));
        */
        public static int birthdayCakeCandles(List<int> candles)
        {
            int max = candles.Count > 0 ? candles[0] : 0;
            int count = 0;
            foreach (var number in candles)
            {
                max = number > max ? number : max;
            }

            foreach (var number in candles)
            {
                if (number == max)
                    count++;
            }
            return count;
        }
    }
}
