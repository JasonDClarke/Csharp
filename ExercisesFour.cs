using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class ExercisesFour
    {
        public static void ExerciseOne()
        {
            Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            var input = Console.ReadLine();

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            numbers.Sort();

            var isConsecutive = true;
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);
        }

        public static void ExerciseTwo()
        {
            Console.WriteLine("Enter some numbers separated by hyphens");
            var input = Console.ReadLine();
            var numbers = new List<int>();
            var areDuplicates = false;
            if (input.Length ==0) { return; }
            foreach (var number in input.Split('-'))
            {
                var value = Convert.ToInt32(number);
                if (numbers.Contains(value))
                {
                    areDuplicates = true;
                    break;
                }
                numbers.Add(value);
            }

            var message = areDuplicates ? "Duplicates" : "No Duplicates";
            Console.WriteLine(message);
        }

        public static void ExerciseThree()
        {
            Console.Write("Enter time: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var components = input.Split(':');
            if (components.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid Time");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
            }
        }

        public static void ExerciseFour()
        {
            Console.WriteLine("Enter words separated by spaces");
            var input = Console.ReadLine();
            var phrase = new StringBuilder();
            foreach(var word in input.Split(' '))
            {
                phrase.Append(Char.ToUpper(word[0]));
                phrase.Append(word.Substring(1).ToLower());
            }
            Console.WriteLine(phrase);
        }

        public static void ExerciseFive()
        {
            Console.WriteLine("Enter a word");
            var input = Console.ReadLine();
            var count = 0;
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            foreach(var character in input)
            {
                if (vowels.Contains(Char.ToLower(character))) {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
