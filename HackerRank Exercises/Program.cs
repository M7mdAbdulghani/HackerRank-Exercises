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
            var a = new List<int>() { 2, 4 };

            var b = new List<int>() { 16, 32, 96 };

            // Console.WriteLine( getTotalX(a, b));


            // Console.WriteLine("******************");


            // Console.WriteLine(getGCF(12, 8));


            // var numbers = new List<int>() { 4, 6, 8 }; // Should be 24 True
            // var numbers = new List<int>() { 48, 72, 108 }; // Should be 432 True 
            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Should be 432 True 
            var result = numbers[0];
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                result = getLCM(result, numbers[i + 1]);
            }
            //Console.WriteLine(result);
        }


        public static int getGCF(int a, int b)
        {
            if (a == 0)
                return b;

            while(b != 0)
            {
                int temp = a;
                a = b;
                b = temp % b;
            }
            return a;
        }

        public static int getLCM(int a, int b)
        {
            return (Math.Abs(a) * Math.Abs(b)) / getGCF(a, b); 
        }

        
        
        
        public static int getTotalX(List<int> a, List<int> b)
        {
            // Sorting
            a.Sort();
            b.Sort();
            // Getting Last(1) And First(2) Numbers
            var x = a[a.Count - 1];
            var y = b[0];
            var startArray = x;
            var endArray = y;
            // In Case of first array bigger than second
            if(x > y)
            {
                x = b[b.Count - 1];
                y = a[0];
            }

            int count = 0;

            // Upper Array
            for (int i = x; i <= y; i++)
            {
                var condition = true ;
                // First Array
                for (int j = 0; j < a.Count; j++)
                {
                    if (startArray > endArray ? (a[j] % i != 0) : (i % a[j] != 0))
                    {
                        condition = false;
                        break;
                    }
                }

                if (!condition)
                    continue;

                // Second Array
                for (int j = 0; j < b.Count; j++)
                {
                    if (startArray > endArray ? (i % b[j] != 0) : (b[j] % i != 0))
                    {
                        condition = false;
                        break;
                    }
                }

                if (!condition)
                    continue;

                count++;
            }

            return count;
        }
    }
}
