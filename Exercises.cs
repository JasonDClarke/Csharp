using System;
using System.Collections.Generic;
using System.Text;

namespace helloworld
{
    class Exercises
    {
    public static void ExerciseOne()
        {
            Console.WriteLine("Give a number");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

    public static void ExerciseTwo()
        {
            Console.WriteLine("insert InputOne");
            var inputOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("insert InputTwo");
            var inputTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(inputOne > inputTwo ? inputOne : inputTwo);
        }
    
    public static void ExerciseThree()
        {
            Console.WriteLine("insert Height");
            var Height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("insert Width");
            var Width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Height > Width ? "Portrait" : "Landscape");
        }
    
    public static void ExerciseFour()
        {
            Console.WriteLine("Give speed Limit");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give speed");
            var speed = Convert.ToInt32(Console.ReadLine());
            if (speedLimit > speed)
            {
                Console.WriteLine("OK");
            }
            else if (speed >= (speedLimit + 12 * 5))
            {
                Console.WriteLine("License revoked");
            }
            else
            {
                int points = (speed - speedLimit) / 5; //int division rounds result towards 0
                Console.WriteLine(points + " Points added to license");
            }
        }

    }
}
