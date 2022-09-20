using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_Exercises
{
    public static class AngryProfessor
    {
        /* 
            Exercise URL
            https://www.hackerrank.com/challenges/angry-professor/problem

            int k = 3;
            var numbers = new List<int>() { -2, -1, 0, 1, 2 };

            Console.WriteLine(angryProfessor(k, numbers));
        */
        public static string angryProfessor(int k, List<int> a)
        {
            int count = 0;
            foreach (var number in a)
            {
                if (number <= 0)
                    count++;
            }
            return count >= k ? "NO" : "YES";
        }
    }
}
