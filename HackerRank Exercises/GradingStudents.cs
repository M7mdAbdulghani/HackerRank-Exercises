using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_Exercises
{
    public static class GradingStudents
    {
        /* 
            Exercise URL
            https://www.hackerrank.com/challenges/grading/problem?isFullScreen=true

            var grades = new List<int>();

            grades.Add(73);
            grades.Add(67);
            grades.Add(38);
            grades.Add(33);

            Console.WriteLine(gradingStudents(grades)); 
        */
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
    }
}
