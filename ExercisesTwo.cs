using System;
using System.Collections.Generic;
using System.Text;

namespace helloworld
{
    class ExercisesTwo
    {
        public static void ExerciseOne()
        {
            var count = 0;
            var value = 3;
            while (value <100)
            {
                count++;
                value += 3;
            }
            Console.WriteLine(count);
        }

        public static void ExerciseTwo()
        {
            Console.WriteLine("Write numbers to sum or ok to exit");
            var input = Console.ReadLine();
            var count = 0;
            while (input != "ok")
            {
                count += Convert.ToInt32(input);
                Console.WriteLine(count);
                input = Console.ReadLine();
            }
        }

        public static void ExerciseThree()
        {
            Console.WriteLine("Number to Factorial:");
            var input = Convert.ToInt32(Console.ReadLine());
            var answer = 1;
            for (var i = 1; i <= input; i++)
            {
                answer *= i;
            }
            Console.WriteLine(answer);
        }

        public static void ExerciseFour()
        {
            Console.WriteLine("Guess a number");
            var random = new Random();
            var secretNumber = random.Next(1, 10);
            var noOfGuesses = 4;
            int guess;
            for (var i = 1; i<= noOfGuesses;i++)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == secretNumber)
                {
                    Console.WriteLine("You won!");
                    break;
                }
                else
                {
                    Console.WriteLine("Guess again!");
                    if (i == noOfGuesses)
                    {
                        Console.WriteLine("You Lost!");
                    }
                }
            }

        }

        public static void ExerciseFive()
        {
            Console.WriteLine("Write a series of numbers separated by a comma");
            string input = Console.ReadLine();
            string[] numberStringArray = input.Split(',');
            int max = int.MinValue;
            foreach(var numberString in numberStringArray)
            {
                var number = Convert.ToInt32(numberString); 
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine("Max is " + max);
        }
    }
}
