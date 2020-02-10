using System;
using System.Collections.Generic;
using System.Text;

namespace HalickiCodeChallenges.Challenge.Sorting
{
    /// <summary>
    /// A program that prints from 1 to 100.
    /// if multiple of 3: prints "Fizz"
    /// if multiple of 5: prints "Buzz"
    /// if multiple of both: prints "FizzBuzz"
    /// </summary>
    public class FizzBuzz : IRunnable
    {
        public static int mMaxNumber = 100;

        public void Run()
        {
            Console.WriteLine($"FizzBuzz:");
            Console.WriteLine($"================");

            for (int i = 1; i < mMaxNumber; i++)
            {
                var isThreeMultiple = i % 3 == 0;
                var isFiveMultiple = i % 5 == 0;

                if (isThreeMultiple && isFiveMultiple)
                {
                    Console.WriteLine($"FizzBuzz  ({i})");
                    continue;
                }
                else if(isThreeMultiple)
                {
                    Console.WriteLine($"Fizz  ({i})");
                    continue;
                }
                else if (isFiveMultiple)
                {
                    Console.WriteLine($"Buzz  ({i})");
                    continue;
                }

                Console.WriteLine(i);
            }
        }

    }
}
