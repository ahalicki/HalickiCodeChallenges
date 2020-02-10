using System;

namespace HalickiCodeChallenges
{
    public static class TestArrayGenerator
    {
        public static int[] GetRandomArray(int size = 20, int maxNumber = 100)
        {
            var result = new int[size];
            var random = new Random();

            for(int i = 0; i < size; i++)
            {
                result[i] = random.Next(0, maxNumber);
            }

            return result;
        }
    }
}
