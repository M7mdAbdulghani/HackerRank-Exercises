using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace HackerRank_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing Diagonal Difference
            /*
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
            /******************************************************************************************************************************************************/

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

            /******************************************************************************************************************************************************/

            // Testing Time Conversion


            // string time = "12:01:00PM";
            /*
                string time = "07:05:45PM";
                string timeResult = "";

                bool isMorning = time.ToLower().Contains("am") ? true : false;
                string hour = time.Substring(0, 2);
                string timeRestCharacters = time.Substring(time.IndexOf(':')).Replace("AM", "").Replace("PM", "");
                int hourInNumbers = int.Parse(hour);

            
                if (isMorning)
                {
                    timeResult = hour == "12" ? "00" : hour;
                }
                else
                {
                    timeResult = hour == "12" ? hour : (hourInNumbers + 12).ToString();
                }

                Console.WriteLine(timeResult + timeRestCharacters);
            */

            /******************************************************************************************************************************************************/


            // Testing Birthday Cake Candles
            /*
                var candles = new List<int>();
                candles.Add(4);
                candles.Add(4);
                candles.Add(1);
                candles.Add(3);

                Console.WriteLine("Count is " + birthdayCakeCandles(candles));
            */

            /******************************************************************************************************************************************************/

            // Testing Grading Students
            /* 
                var grades = new List<int>();

                grades.Add(73);
                grades.Add(67);
                grades.Add(38);
                grades.Add(33);

            */

            /******************************************************************************************************************************************************/


            // Testing Apple And Orange
            /* 
                int s = 7;
                int t = 10;
                int a = 4;
                int b = 12;

                int applesCount = 0;
                int orangesCount = 0;

                var apples = new List<int>();
                apples.Add(2);
                apples.Add(3);
                apples.Add(-4);

                var oranges = new List<int>();
                oranges.Add(3);
                oranges.Add(-2);
                oranges.Add(-4);


                foreach (var apple in apples)
                {
                    applesCount += ((apple + a) >= s && (apple + a) <= t) ? 1 : 0;
                }

                foreach (var orange in oranges)
                {
                    orangesCount += ((orange + b) >= s && (orange + b) <= t) ? 1 : 0;
                }

                Console.WriteLine(applesCount);
                Console.WriteLine(orangesCount); 
            */

            /******************************************************************************************************************************************************/


            // Testing Breaking The Records
            /* 
                var scores = new List<int>();

                //10 5 20 20 4 5 2 25 1
                scores.Add(10);
                scores.Add(5);
                scores.Add(20);
                scores.Add(20);
                scores.Add(4);
                scores.Add(5);
                scores.Add(2);
                scores.Add(25);
                scores.Add(1);

                breakingRecords(scores); 
            */

            /******************************************************************************************************************************************************/

            // Testing Equalize The array
            /* 
                List<int> arr = new List<int>() { 24, 29, 70, 43, 12, 27, 29, 24, 41, 12, 41, 43, 24,
                                              70, 24, 100, 41, 43, 43, 100, 29, 70, 100, 43, 41, 27,
                                              70, 70, 59, 41, 24, 24, 29, 43, 24, 27, 70, 24, 27, 70,
                                              24, 70, 27, 24, 43, 27, 100, 41, 12, 70, 43, 70, 62, 12,
                                              59, 29, 62, 41, 100, 43, 43, 59, 59, 70, 12, 27, 43, 43, 27,
                                              27, 27, 24, 43, 43, 62, 43, 70, 29 };
                // List<int> arr = new List<int>() { 1, 2, 3, 1, 2, 3, 3, 3 };
            */

            /******************************************************************************************************************************************************/

            // Testing Library Fine
            /*
                int d1 = 9;
                int m1 = 6;
                int y1 = 2015;

                // Due
                int d2 = 6;
                int m2 = 6;
                int y2 = 2015;

                Console.WriteLine(libraryFine(d1, m1, y1, d2, m2, y2));
            */

            /******************************************************************************************************************************************************/


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

      
        
        // Diagonal Difference (My Solution)
        /*
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
        */

        // Diagonal Difference (More Optimized Solution)
        /*
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
        */

        /******************************************************************************************************************************************************/

        // Time Conversion
        /* 
            public static string timeConversion(string s)
            {
                string timeResult = "";
                bool isMorning = s.ToLower().Contains("am") ? true : false;
                    string hour = s.Substring(0, 2);
                    string timeRestCharacters = s.Substring(s.IndexOf(':')).Replace("AM", "").Replace("PM", "");
                    int hourInNumbers = int.Parse(hour);

            
                    if (isMorning)
                    {
                        timeResult = hour == "12" ? "00" : hour;
                    }
                    else
                    {
                        timeResult = hour == "12" ? hour : (hourInNumbers + 12).ToString();
                    }

                    return timeResult + timeRestCharacters;
            }
         */

        /******************************************************************************************************************************************************/

        // Birthday Cake Candles
        /*
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
        */

        /******************************************************************************************************************************************************/

        // Grading Students
        /* 
            public static List<int> gradingStudents(List<int> grades)
            {
                var updatedGrades = new List<int>();


                    foreach (var grade in grades)
                    {
                        if (grade < 38)
                            updatedGrades.Add(grade);
                        else
                        {
                            var roundedGrade = 5 - (grade % 5) >= 3 ? grade : grade + 5 - (grade % 5);
                            updatedGrades.Add(roundedGrade);
                        }
                    }

                    return updatedGrades;
            } 
        */


        /******************************************************************************************************************************************************/

        // Apple And Orange
        /* 
            public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
            {
                int applesCount = 0;
                int orangesCount = 0;
                foreach (var apple in apples)
                {
                    applesCount += ((apple + a) >= s && (apple + a) <= t) ? 1 : 0;
                }

                foreach (var orange in oranges)
                {
                    orangesCount += ((orange + b) >= s && (orange + b) <= t) ? 1 : 0;
                }
        
                Console.WriteLine(applesCount);
                Console.WriteLine(orangesCount);
            }
        */

        /******************************************************************************************************************************************************/

        // Breaking The Records
        /* 
            public static List<int> breakingRecords(List<int> scores)
            {
                var resultScores = new List<int>();
                int min = 0;
                int max = 0;

                int highestScore = 0;
                int lowestScore = 0;

            
                for (int i = 0; i < scores.Count; i++)
                {
                    if(i == 0)
                    {
                        highestScore = scores[i];
                        lowestScore = scores[i];
                        continue;
                    }

                    // Bigger
                    if(scores[i] > highestScore)
                    {
                        max++;
                        highestScore = scores[i];
                    }


                    // Lower
                    if (scores[i] < lowestScore)
                    {
                        min++;
                        lowestScore = scores[i];
                    }
                }

                resultScores.Add(max);
                resultScores.Add(min);

                return resultScores;
            }  
        */

        /******************************************************************************************************************************************************/


        // Equalize The Array (My Solution)
        /* 
            public static int equalizeArray(List<int> arr)
            {
                //Dictionary<int, int> numbersCount = new Dictionary<int, int>();
                //for (int i = 0; i < arr.Count; i++)
                //{
                //    int count = 0;
                //    for (int j = 0; j < arr.Count; j++)
                //    {
                //        if (arr[j] == arr[i])
                //        {
                //            count++;
                //        }
                //    }

                //    if (!numbersCount.ContainsKey(arr[i]))
                //    {
                //        numbersCount.Add(arr[i], count);
                //    }
                //}

                //for (int i = 0; i < numbersCount.Count; i++)
                //{
                //    Console.WriteLine("Key: " + numbersCount.ElementAt(i).Key + ", Value: " + numbersCount.ElementAt(i).Value);
                //}

                //int counter = 0;
                //int max = 0;
                //for (int i = 0; i < numbersCount.Count; i++)
                //{
                //    if (numbersCount.ElementAt(i).Value > max)
                //    {
                //        counter += max;
                //        max = numbersCount.ElementAt(i).Value;
                //    }
                //    else
                //    {
                //        counter += numbersCount.ElementAt(i).Value;
                //    }
                //}
                // return counter;
            }       
        */

        // Equalize The Array (More Optimized Solution)
        /*
            public static int equalizeArray(List<int> arr)
            {
                int[] occurences = new int[101];
                int max = 0;

                for (int i = 0; i < arr.Count; i++)
                {
                    int number = arr[i];
                    occurences[number]++;
                    if(occurences[number] > max)
                    {
                        max = occurences[number];
                    }
                }

                return arr.Count - max;
            } 
        */

        /******************************************************************************************************************************************************/


        // Library Fine
        /* 
            public static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
            {
                if (y1 > y2)
                {
                    return 10000;
                }

                else
                {
                    if (y1 == y2 && m1 > m2)
                    {
                        return 500 * (m1 - m2);
                    }
                    else if (y1 == y2 && m2 == m1 && d1 > d2)
                    {
                        return 15 * (d1 - d2);
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        */

        // Library Fine (More Better Solution)
        /* 
            public static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
            {
                if (y1 > y2)
                {
                    return 10000;
                }

                if (y1 == y2 && m1 > m2)
                {
                    return 500 * (m1 - m2);
                }

                if (y1 == y2 && m2 == m1 && d1 > d2)
                {
                    return 15 * (d1 - d2);
                }

                return 0;
            }
        */

        /******************************************************************************************************************************************************/


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
