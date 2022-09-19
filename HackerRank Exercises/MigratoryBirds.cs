using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_Exercises
{
    public static class MigratoryBirds
    {
        /* 
            Exercise URL
            https://www.hackerrank.com/challenges/migratory-birds/problem?isFullScreen=true

            var arr = new List<int>() { 1, 1, 2, 2, 3 };
            // var arr = new List<int>() { 1, 4, 4, 4, 5, 3 };
            // var arr = new List<int>() { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4};
            // var arr = new List<int>() { 1, 2, 3, 3, 2, 2 };
            // var arr = new List<int>() { 1, 2, 1, 2, 1, 2, 4 };

            Console.WriteLine(migratoryBirds(arr));
        */
        public static int migratoryBirds(List<int> arr)
        {
            int[] occurences = new int[6];
            int max = 0;
            int min = 0;
            int maxType = 0;
            int minType = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                int number = arr[i];
                occurences[number]++;
                if (occurences[number] == max)
                {
                    min = occurences[number];
                    minType = number;
                }
                else if (occurences[number] > max)
                {
                    max = occurences[number];
                    maxType = number;
                }
            }
            return (min == max) ? (minType > maxType ? maxType : minType) : maxType;
        }
        public static int migratoryBirdsOptimized(List<int> arr)
        {
            int[] occurences = new int[6];


            for (int i = 0; i < arr.Count; i++)
            {
                int number = arr[i];
                occurences[number]++;
            }

            int max = occurences[1];
            int id = 1;

            for (int i = 2; i < occurences.Length; i++)
            {
                if (occurences[i] > max)
                {
                    max = occurences[i];
                    id = i;
                }
            }

            return id;
        }
    }
}
