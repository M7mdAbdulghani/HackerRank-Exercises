﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace HackerRank_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Testing Compare Triplets 
            /*
                var numbers = new List<long>();
                // 7 69 2 221 8974
                numbers.Add(7);
                numbers.Add(69);
                numbers.Add(2);
                numbers.Add(221);
                numbers.Add(8974);
                numbers.Sort();


                long maxNumber = 0;
                long minNumber = 0;

                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    minNumber += numbers[i];
                }

                for (int j = 1; j < numbers.Count; j++)
                {
                    maxNumber += numbers[j];
                }

                Console.WriteLine(minNumber + " " + maxNumber);
            */



            // Testing Divisible Sum Pairs
            /* 
                var ar = new List<int>() { 1, 2, 3, 4, 5, 6 };
                int k = 5;
                Console.WriteLine(divisibleSumPairs(ar.Count, k, ar));
            */


            /******************************************************************************************************************************************************/


            // Testing Number Line Jumps 
            /* 
                int x1 = 43;
                int v1 = 2;

                int x2 = 70;
                int v2 = 2;

                Console.WriteLine(kangaroo(x1, v1, x2, v2));
            */

            /******************************************************************************************************************************************************/


            // Testing Migratory Birds
            /* 
                var arr = new List<int>() { 1, 1, 2, 2, 3 };
                // var arr = new List<int>() { 1, 4, 4, 4, 5, 3 };
                // var arr = new List<int>() { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4};
                // var arr = new List<int>() { 1, 2, 3, 3, 2, 2 };
                // var arr = new List<int>() { 1, 2, 1, 2, 1, 2, 4 };

                Console.WriteLine(migratoryBirds(arr));
            */


            /******************************************************************************************************************************************************/


            // Testing Bill Division
            /*
                var bill = new List<int>() { 3, 10, 2, 9 };
                int b = 12;
                int k = 1;


                bonAppetit(bill, k, b);
            */

            /******************************************************************************************************************************************************/


            //List<int> ar = new List<int>() { 10, 20, 20, 10, 10, 30, 50, 10, 20 };

            //int[] occurences = new int[101];

            //int counter = 0;
            //for (int i = 0; i < ar.Count; i++)
            //{
            //    int number = ar[i];
            //    occurences[number]++;

            //    if(occurences[number] == 2)
            //    {
            //        counter++;
            //        occurences[number] = 0;
            //    }
            //}
            //Console.WriteLine(counter);

            //Console.WriteLine(Math.Log2(10));

            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            //long number = 1000000000;
            //bool result = true;

            //for (long i = 2; i < Math.Sqrt(number); i++)
            //{
            //    if (number % i == 0)
            //        result = false;
            //}
            //Console.WriteLine(result);
            //stopwatch.Stop();
            //Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);


            //int x = 1;
            //int y = 3;
            //int z = 2;
            ////1 3 2

            //int catAPosition = x;
            //int catBPosition = y;
            //int mousePosition = z;

            //int catADifference = Math.Abs(mousePosition - catAPosition);
            //int catBDifference = Math.Abs(mousePosition - catBPosition);

            //Console.WriteLine(catADifference > catBDifference ? "Cat B" : catBDifference > catADifference ? "Cat A" : "Mouse C");

        }



        // Divisble Sum Pairs
        /* 
            public static int divisibleSumPairs(int n, int k, List<int> ar)
            {
                int counter = 0;
                for (int i = 0; i < ar.Count; i++)
                {
                    int number = ar[i];
                    for (int j = 0; j < ar.Count; j++)
                    {
                        if (j == i)
                            continue;
                        else if ((number + ar[j]) % k == 0)
                            counter++;
                    }
                }
                return counter / 2;
            }     
        */


        /******************************************************************************************************************************************************/


        // Number Line Jumps
        /* 
            public static string kangaroo(int x1, int v1, int x2, int v2)
            {
                for (var i = 0; i <= 10000; i++)
                {
                    if ((x1 + v1) == (x2 + v2))
                    {
                        return "YES";
                    }
                    x1 += v1;
                    x2 += v2;
                }
                return "NO";
            } 
        */

        /******************************************************************************************************************************************************/


        // Migratory Birds
        /*
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
        */

        // Migratory Birds (More Optimized Solutions)
        /* 
            public static int migratoryBirds(List<int> arr)
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
        */

        /******************************************************************************************************************************************************/


        // Bill Division
        /*
            public static void bonAppetit(List<int> bill, int k, int b)
            {
                int totalAnnaShouldPay = 0;

                for (int i = 0; i < bill.Count; i++)
                {
                    if (i == k)
                        continue;
                    totalAnnaShouldPay += bill[i];
                }
                totalAnnaShouldPay = totalAnnaShouldPay / 2;

                if (totalAnnaShouldPay == b)
                    Console.WriteLine("Bon Appetit");
                else
                    Console.WriteLine(b - totalAnnaShouldPay);
            }
        */

        /******************************************************************************************************************************************************/


    }
}
