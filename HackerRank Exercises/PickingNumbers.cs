using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_Exercises
{
    public static class PickingNumbers
    {
        /* 
            Exercise URL
            https://www.hackerrank.com/challenges/picking-numbers/problem?isFullScreen=true

            var numbers = new List<int>() { 4, 2, 3, 4, 4, 9, 98, 98, 3, 3, 3, 4, 2, 98, 1, 98, 98, 1, 1, 4, 98, 2, 98, 3, 9, 9, 3, 1, 4, 1, 98, 9, 9, 2, 9, 4, 2, 2, 9, 98, 4, 98, 1, 3, 4, 9, 1, 98, 98, 4, 2, 3, 98, 98, 1, 99, 9, 98, 98, 3, 98, 98, 4, 98, 2, 98, 4, 2, 1, 1, 9, 2, 4 };

            //numbers.Add(1);
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(2);
            //numbers.Add(4);
            //numbers.Add(4);
            //numbers.Add(5);
            //numbers.Add(5);
            //numbers.Add(5);


            //1 2 2 3 1 2
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(2);
            //numbers.Add(3);
            //numbers.Add(1);
            //numbers.Add(2);


            //4 6 5 3 3 1
            // 1 3 3 4 5 6
            //numbers.Add(4);
            //numbers.Add(6);
            //numbers.Add(5);
            //numbers.Add(3);
            //numbers.Add(3);
            //numbers.Add(1);

            Console.WriteLine(pickingNumbers(numbers));
        */
        public static int pickingNumbers(List<int> a)
        {
            a.Sort();
            int difference = 1;
            int checkNumber = a[0];

            int count = 0;
            int previousCount = 0;

            for (int i = 0; i < a.Count - 1; i++)
            {
                if (a[i] == a[i + 1])
                {
                    count++;
                    continue;
                }

                if (Math.Abs(a[i + 1] - a[i]) <= difference
                    && Math.Abs(a[i + 1] - checkNumber) <= difference)
                {
                    checkNumber = a[i];
                    count++;
                    continue;
                }
                checkNumber = (i + 1 == a.Count) ? a[i] : a[i + 1];
                previousCount = count > previousCount ? count : previousCount;
                count = 0;
            }

            return (previousCount > count) ? previousCount + 1 : count + 1;
        }
    }
}
