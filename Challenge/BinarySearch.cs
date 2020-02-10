using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace HalickiCodeChallenges.Challenge.Sorting
{
    /// <summary>
    /// Performs a binary search over some preset data.
    /// "binary" in this context means to split down the
    /// middle; to have a dichotomy 1|0.
    /// </summary>
    public class BinarySearch : IRunnable
    {
        int mTarget = 150;
        bool mFound = false;
        DisplayMode mMode = DisplayMode.StepByStep;

        /// <summary>
        /// Runs the search and displays output to console.
        /// </summary>
        public void Run()
        {
            Console.WriteLine($"Binary Search:");
            Console.WriteLine($"================");

            // Take any SORTED array of values.
            int[] testArgs = { 1, 5, 89, 72, 44, 89, 11, 23, 29, 12, 150, 80, 22, 73, 39, 99 };
            Array.Sort(testArgs);

            Console.WriteLine($"Searching for: {mTarget}");

            if (mMode == DisplayMode.QuickDisplay)
            {
                Console.WriteLine($"Searching over array: {string.Join(" ", testArgs)}");

                // Record time and begin the search.
                var start = DateTime.Now;
                var result = RecursiveBinarySearch(testArgs, 0, testArgs.Length);
                var finish = DateTime.Now;

                var delta = finish - start;

                Console.WriteLine(mFound ? $"Found at index: {result} {Environment.NewLine} in time: {delta.TotalSeconds}" :
                                           $"Value: {mTarget} was not found.");

                return;
            }
            else if (mMode == DisplayMode.StepByStep)
            {
                var result = RecursiveBinarySearch(testArgs, 0, testArgs.Length);

                Console.WriteLine(mFound ? $"Found at index: {result} {Environment.NewLine}" :
                                           $"Value: {mTarget} was not found.");

                if (mFound)
                {
                    var highlightedResults = new List<string>(testArgs.Select(i => i.ToString()));
                    highlightedResults[result] = $"[{highlightedResults[result]}]";

                    Console.WriteLine(string.Join(" ", highlightedResults));
                }

                return;
            }
        }

        private int RecursiveBinarySearch(int[] sortedArgs, int min, int max)
        {
            // Take the middle value.
            var mid = (max + min) / 2;
            
            if (mMode != DisplayMode.QuickDisplay)
            {
                Console.WriteLine($"Searching over array: { string.Join(" ", sortedArgs.Skip(min).TakeWhile(val => val <= sortedArgs[max-1])) }");
                Thread.Sleep(2000);
            }

            // Determine if our target is the middle value.
            if (mTarget == sortedArgs[mid])
            {
                mFound = true;
                return mid;
            }
            
            if (sortedArgs[mid] <= sortedArgs[min] ||
                sortedArgs[mid] >= sortedArgs[max - 1])
            {
                mFound = false;
                return -1;
            }

            // If not,
            else if (sortedArgs[mid] < mTarget)
            {
                // the target is above us.
                return RecursiveBinarySearch(sortedArgs, mid, max);
            }
            else
            {
                // The target is below us.
                return RecursiveBinarySearch(sortedArgs, min, mid);
            }
        }

        private enum DisplayMode
        {
            QuickDisplay,
            StepByStep,
        }
    }
}