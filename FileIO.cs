using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp2
{
    class FileIO
    {
    public static int noOfWords(string text)
        {
            var count = 0;
            foreach(var word in text.Split(' '))
            {
                count++;
            }
            return count;
        }

    public static string longestWord(string text)
        {
            string longestWord = " ";
            var max = 1;
            foreach (var word in text.Split(' ', '.', '!'))
            {
                if (word.Length> max)
                {
                    max = word.Length;
                    longestWord = word;
                }
            }

            return longestWord;
        }
    }
}
