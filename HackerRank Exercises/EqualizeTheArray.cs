using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank_Exercises
{
    public static class  EqualizeTheArray
    {
        /* 
            Exercise URL
            https://www.hackerrank.com/challenges/equality-in-a-array/problem?isFullScreen=true

            List<int> arr = new List<int>() { 24, 29, 70, 43, 12, 27, 29, 24, 41, 12, 41, 43, 24,
                                              70, 24, 100, 41, 43, 43, 100, 29, 70, 100, 43, 41, 27,
                                              70, 70, 59, 41, 24, 24, 29, 43, 24, 27, 70, 24, 27, 70,
                                              24, 70, 27, 24, 43, 27, 100, 41, 12, 70, 43, 70, 62, 12,
                                              59, 29, 62, 41, 100, 43, 43, 59, 59, 70, 12, 27, 43, 43, 27,
                                              27, 27, 24, 43, 43, 62, 43, 70, 29 };
            // List<int> arr = new List<int>() { 1, 2, 3, 1, 2, 3, 3, 3 };

            Console.WriteLine(equalizeArray(arr));
        */

        public static int equalizeArray(List<int> arr)
        {
            Dictionary<int, int> numbersCount = new Dictionary<int, int>();
            for (int i = 0; i < arr.Count; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Count; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        count++;
                    }
                }

                if (!numbersCount.ContainsKey(arr[i]))
                {
                    numbersCount.Add(arr[i], count);
                }
            }

            for (int i = 0; i < numbersCount.Count; i++)
            {
                Console.WriteLine("Key: " + numbersCount.ElementAt(i).Key + ", Value: " + numbersCount.ElementAt(i).Value);
            }

            int counter = 0;
            int max = 0;
            for (int i = 0; i < numbersCount.Count; i++)
            {
                if (numbersCount.ElementAt(i).Value > max)
                {
                    counter += max;
                    max = numbersCount.ElementAt(i).Value;
                }
                else
                {
                    counter += numbersCount.ElementAt(i).Value;
                }
            }
            return counter;
        }


        public static int equalizeArrayOptimized(List<int> arr)
        {
            int[] occurences = new int[101];
            int max = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                int number = arr[i];
                occurences[number]++;
                if (occurences[number] > max)
                {
                    max = occurences[number];
                }
            }

            return arr.Count - max;
        }
    }
}
