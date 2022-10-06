using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank_Exercises
{
    public class CircularArrayRotation
    {
        /* 
            Exercise URL
            https://www.hackerrank.com/challenges/circular-array-rotation/problem?isFullScreen=true

            var a = new List<int>() { 3, 4, 5 };
            var k = 2;
            var queries = new List<int>() { 1, 2 };

            circularArrayRotation(a, k, queries);
        */
        public static List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
        {
            // Copy
            var copyArray = a.ToList();

            for (int i = 0; i < copyArray.Count; i++)
            {
                var condition = (i + k) % copyArray.Count;
                a[condition] = copyArray[i];
            }

            var result = new List<int>();
            foreach (var index in queries)
            {
                result.Add(a[index]);
            }

            return result;
        }

        // This solution didn't pass all test cases (because of time issues) but the idea is good (Suggested by Renad)
        public static List<int> circularArrayRotationAnotherSolution(List<int> a, int k, List<int> queries)
        {
            if (k != 0)
            {
                k = k - 1;
                int lastElement = a[a.Count - 1];
                for (int i = a.Count - 1; i > 0; i--)
                {
                    a[i] = a[i - 1];
                }
                a[0] = lastElement;
                circularArrayRotation(a, k, queries);
            }

            var result = new List<int>();
            foreach (var index in queries)
            {
                result.Add(a[index]);
            }

            return result;
        }

        // This solution didn't pass all test cases (because of time issues) but the idea is good (Suggested by Renad) --> O (a.Count * k)
        public static List<int> circularArrayRotationAnotherSolution2(List<int> a, int k, List<int> queries)
        {

            int lastLement = a[a.Count - 1];
            for (int i = a.Count - 1; i > 0; i--)
            {
                a[i] = a[i - 1];

                if ((i - 1) == 0)
                {
                    k--;
                    a[0] = lastLement;
                    if (k != 0)
                    {
                        i = a.Count;
                        lastLement = a[a.Count - 1];
                    }
                }
            }


            var result = new List<int>();
            foreach (var index in queries)
            {
                result.Add(a[index]);
            }

            return result;
        }
    }
}
