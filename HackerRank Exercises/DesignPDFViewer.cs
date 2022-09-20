using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank_Exercises
{
    public static class DesignPDFViewer
    {
        /* 
            Exercise URL
            https://www.hackerrank.com/challenges/designer-pdf-viewer/problem?isFullScreen=true

            var characters = new List<int>() { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            var word = "abc";

            Console.WriteLine(designerPdfViewer(characters, word));
        */
        public static int designerPdfViewer(List<int> h, string word)
        {
            var letters = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
                                             's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

            int maxValue = 0;
            int width = 1;
            int letterLength = word.Length;

            foreach (var letter in word)
            {
                var letterValue = h.ElementAt(letters.IndexOf(letter));
                if (letterValue > maxValue)
                    maxValue = letterValue;
            }
            return maxValue * width * letterLength;
        }
    }
}
