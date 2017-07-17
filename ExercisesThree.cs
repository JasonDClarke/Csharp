using System;
using System.Collections.Generic;
using System.Text;

namespace helloworld
{
    class ExercisesThree
    {
        public static void ExerciseOne()
        {
            var nameList = new List<string>();
            string input;
            do
            {
                Console.WriteLine("Enter a name");
                input = Console.ReadLine();
                if (input.Length !=0)
                {
                    nameList.Add(input);
                }
            } while (input.Length !=0);

            if (nameList.Count==1)
            {
                Console.WriteLine(nameList[0] + " likes your post");
            }
            else if (nameList.Count == 2)
            {
                Console.WriteLine(nameList[0] + ", " + nameList[1] + " like your post.");
            }
            else if (nameList.Count >= 3)
            {
                var others = nameList.Count - 2;
                Console.WriteLine("{0}, {1}, and {2} others like your post", nameList[0], nameList[1], others);
            }
        }

        public static void ExerciseTwo()
        {
            Console.WriteLine("Enter your name");
            var input = Console.ReadLine();
            var inputArray = input.ToCharArray();
            Array.Reverse(inputArray);
            var output = new string(inputArray);
            Console.WriteLine(output);
        }

        public static void ExerciseThree()
        {
            Console.WriteLine("Enter 5 numbers:");
            var numbers = new List<int>();
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a number");
                var input = Convert.ToInt32(Console.ReadLine());
                while (numbers.Contains(input))
                {
                    Console.WriteLine("Error: number already used. Enter another number");
                    input = Convert.ToInt32(Console.ReadLine());
                }
                    numbers.Add(input);
            }
            var max = numbers[0];
            foreach(var number in numbers)
            {
                if (number > max)
                {
                    max = number;
                } 
            }
            Console.WriteLine("Max is " + max);
        }

        public static void ExerciseFour()
        {
            Console.WriteLine("Write numbers to show or QUIT to exit");
            var input = Console.ReadLine();
            var numList = new List<int>();
            while (input != "QUIT")
            {
                numList.Add(Convert.ToInt32(input));
                var output = string.Join(",", numList);
                Console.WriteLine(output);
                input = Console.ReadLine();
            }
        }

        public static void ExerciseFive()
        {
            Console.WriteLine("Write a series of numbers separated by a comma");
            string input = Console.ReadLine();
            string[] numberStringArray = input.Split(',');
            if (numberStringArray.Length < 5)
            {
                Console.WriteLine("Invalid List");
                return;
            }

            Array.Sort(numberStringArray);
            var firstThree = new string[3]; 
           Array.ConstrainedCopy(numberStringArray,0, firstThree, 0, 3);
            var output = string.Join(",",firstThree);
            Console.WriteLine(output);
        }
    }
}
