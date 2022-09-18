using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_Exercises
{
    public static class BillDivision
    {
        /* 
            Exercise URL
            https://www.hackerrank.com/challenges/bon-appetit/problem?isFullScreen=true

            var bill = new List<int>() { 3, 10, 2, 9 };
            int b = 12;
            int k = 1;


            bonAppetit(bill, k, b);
        */

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
    }
}
