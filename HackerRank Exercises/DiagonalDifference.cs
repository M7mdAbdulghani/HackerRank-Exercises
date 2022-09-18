using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_Exercises
{
    public static class DiagonalDifference
    {
        /* 
            Exercise URL
            https://www.hackerrank.com/challenges/diagonal-difference/problem?isFullScreen=true

            var numbers = new List<List<int>>();

            numbers.Add(new List<int>());
            numbers.Add(new List<int>());
            numbers.Add(new List<int>());

            numbers[0].Add(1);
            numbers[0].Add(2);
            numbers[0].Add(3);
            numbers[1].Add(4);
            numbers[1].Add(5);
            numbers[1].Add(6);
            numbers[2].Add(7);
            numbers[2].Add(8);
            numbers[2].Add(9);

            Console.WriteLine(diagonalDifferenceOptimized(numbers)); 
        */

        public static int diagonalDifference(List<List<int>> arr)
        {
            int leftDialog = 0;
            int rightDialog = 0;

            for (var i = 0; i < arr.Count; i++)
            {
                for (var j = 0; j < arr.Count; j++)
                {
                    if (i == j)
                    {
                        leftDialog += arr[i][j];
                    }
                    if (i + j + 1 == arr.Count)
                    {
                        rightDialog += arr[i][j];
                    }
                }
            }
            return Math.Abs(leftDialog - rightDialog);
        }

        public static int diagonalDifferenceOptimized(List<List<int>> arr)
        {
            int leftDialog = 0;
            int rightDialog = 0;
            int count = arr.Count - 1;


            for (var i = 0; i < arr.Count; i++)
            {
                rightDialog += arr[i][count];
                leftDialog += arr[i][i];
                count--;
            }
            return Math.Abs(leftDialog - rightDialog);
        }
    }
}
