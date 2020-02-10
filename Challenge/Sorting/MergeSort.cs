using System;
using System.Collections.Generic;
using System.Text;

namespace HalickiCodeChallenges.Challenge.Sorting
{
    public class MergeSortExample: IRunnable
    {
        public void Run()
        {
            var testArray = TestArrayGenerator.GetRandomArray(size: 20);
            Console.WriteLine($"testing with: {string.Join(", ", testArray)}{Environment.NewLine}");

            // todo:
            //var result = MergeSort(testArray);

            //Console.WriteLine($"result: {string.Join(", ", result)}");
        }
    }
}
