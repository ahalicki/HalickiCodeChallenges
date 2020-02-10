/*
 * Note: I did each of these for fun. Not every solution is the 
 * most performant solution, but all were written by me from scratch.
 * -- Anthony Halicki
 */

using System;
using System.Collections.Generic;
using HalickiCodeChallenges.Challenge;
using HalickiCodeChallenges.Challenge.Sorting;

namespace HalickiCodeChallenges
{
    class CodeChallenges
    {
        /// <summary>
        /// Runs each code challenge  -- coded by aHalicki.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Run(new IRunnable[]
            {
                new FizzBuzz(),
                new PlayerFight(),
                new BinarySearch(),
                new Fibonacci() { AsRecursive = false},
               // todo: Sorting...
               // new BubbleSortExample()
               //  new MergeSortExample(),
               // new QuickSortExample(),
            });
        }

        public static void Run(IEnumerable<IRunnable> s)
        {
            foreach(var runnable in s)
            {
                runnable.Run();
                Console.WriteLine();
            }

            Console.WriteLine("Run complete.");
            Console.ReadLine();
        }
    }
}
