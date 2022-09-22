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
    }
}
