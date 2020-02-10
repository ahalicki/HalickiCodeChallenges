using System;

namespace HalickiCodeChallenges.Challenge.Sorting
{
    /// <summary>
    /// Bubble sort is probably the simplest conceptual sort.
    /// </summary>
    public class BubbleSortExample : IRunnable
    {
        public void Run()
        {
            var testArray = TestArrayGenerator.GetRandomArray(size: 20);
            Console.WriteLine($"testing with: {string.Join(", ", testArray)}{Environment.NewLine}");

            // Note that bubble sort sorts the array "in place"
            // with minimal use of new memory in a temp variable.
            BubbleSort(testArray);

            Console.WriteLine($"result: {string.Join(", ", testArray)}");
        }

        public void BubbleSort(int[] array)
        {
            if (array.Length <= 1)
            {
                // Added protection for an array of size <= 1.
                return;
            }

            bool done = false;
            while (!done)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i - 1] > array[i])
                    {
                        var tmp = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = tmp;

                        // After swapping 2 entries, we break out
                        // of the 'for' loop into the 'while' loop
                        // which restarts the entire process. Not efficient, 
                        // but easy on the brain :)
                        break;
                    }

                    if (i == array.Length - 1)
                    {
                        // Mark complete if  we're at
                        // the end of the array. After leaving the 'for'
                        // loop, we will terminate the 'while' loop and be done.
                        done = true;
                    }
                }
            }
        }
    }
}
