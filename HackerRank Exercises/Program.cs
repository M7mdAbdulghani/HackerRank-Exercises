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
            //var a = new List<int>() { 2, 4 };

            //var b = new List<int>() { 16, 32, 96 };

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
            // Console.WriteLine(beautifulDays(20, 23, 6));
            // Console.WriteLine(beautifulDays(1, 1000000000, 189));
            // Console.WriteLine(birthday(new List<int>() { 1, 2, 1, 3, 2 }, 3, 2));
        }

        public static int birthday(List<int> s, int d, int m)
        {
            int count = 0;
            for (int i = 0; i < s.Count(); i++)
            {
                int sum = 0;
                for (int j = i; j < (m + i) && j < s.Count(); j++)
                {
                    sum += s[j];
                }
                if (sum == d)
                    count++;
            }
            return count;
        }

        public static int beautifulDays(int i, int j, int k)
        {
            //string test = "XYZ";
            

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            // Thread.Sleep(5000);

            string reverseInString = "";

            int count = 0;
            for (int m = i; m <= j; m++)
            {
                string numberInstring = m.ToString();
                char[] charArray = numberInstring.ToCharArray(); /// N
                Array.Reverse(charArray); // N
                reverseInString = new string(charArray);
                //for (var t = numberInstring.Length - 1; t >= 0; t--)
                //    reverseInString += numberInstring[t];

                int reverse = int.Parse(reverseInString);

                int numbersDifference = m - reverse;
                if (numbersDifference % k == 0)
                    count++;
            }
            stopwatch.Stop();

            Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
            return count;
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
