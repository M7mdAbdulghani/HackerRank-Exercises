using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_Exercises
{
    public static class BreakingTheRecord
    {
        /* 
            Exercise URL
            https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem?isFullScreen=true

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

        public static List<int> breakingRecords(List<int> scores)
        {
            var resultScores = new List<int>();
            int min = 0;
            int max = 0;

            int highestScore = 0;
            int lowestScore = 0;


            for (int i = 0; i < scores.Count; i++)
            {
                if (i == 0)
                {
                    highestScore = scores[i];
                    lowestScore = scores[i];
                    continue;
                }

                // Bigger
                if (scores[i] > highestScore)
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
    }
}
