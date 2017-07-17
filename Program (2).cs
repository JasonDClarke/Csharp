using System;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args) { 
            var path = System.IO.Directory.GetCurrentDirectory() + @"\\text.txt";
            Console.WriteLine(path);

            var text = File.ReadAllText(path);
            Console.WriteLine(FileIO.noOfWords(text));
            Console.WriteLine(FileIO.longestWord(text));
        }
    }
}