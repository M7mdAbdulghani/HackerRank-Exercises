using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_Exercises
{
    public static class CatsAndMouse
    {
        /* 
            Exercise URL
            https://www.hackerrank.com/challenges/cats-and-a-mouse/problem?isFullScreen=true

            int x = 1;
            int y = 3;
            int z = 2;
            
            1 3 2

            Console.WriteLine(catAndMouse(x, y, z)); 
        */
        public static string catAndMouse(int x, int y, int z)
        {
            int catAPosition = x;
            int catBPosition = y;
            int mousePosition = z;

            int catADifference = Math.Abs(mousePosition - catAPosition);
            int catBDifference = Math.Abs(mousePosition - catBPosition);

            return catADifference > catBDifference ? "Cat B" : catBDifference > catADifference ? "Cat A" : "Mouse C";
        }
    }
}
