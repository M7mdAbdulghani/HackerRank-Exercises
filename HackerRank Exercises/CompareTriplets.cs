using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_Exercises
{
    public static class CompareTriplets
    {

        /* 
            Exercise URL
            https://www.hackerrank.com/challenges/compare-the-triplets/problem?isFullScreen=true

            Input
            5 6 7
            3 6 10
            OutPut
            1 1 

            ------- 
        */
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            var resultList = new List<int>();
            var alicePoints = 0;
            var bobPoints = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                    alicePoints++;
                else if (b[i] > a[i])
                    bobPoints++;
            }
            resultList.Add(alicePoints);
            resultList.Add(bobPoints);
            return resultList;
        }
    }
}
