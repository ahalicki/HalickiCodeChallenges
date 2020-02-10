using System;
using System.Collections.Generic;
using System.Text;

namespace HalickiCodeChallenges.Challenge
{
    public class Fibonacci : IRunnable
    {
        public int MaxSequence { get; set; } = 20;
        public bool AsRecursive { get; set; }

        static List<int> fibs = new List<int>();

        public void Run()
        {
            if (AsRecursive)
                RunRecursive(1, 0);
            else
                RunIterative(1, 0);

            Console.WriteLine(string.Join(", ", fibs));
        }

        public void RunRecursive(int num1, int num2)
        {
            int count = 0;

            RFibs(num1, num2);
            return;

            #region embedded recursive method

            void RFibs(int n1, int n2)
            {
                count++;
                if (count > MaxSequence)
                {
                    return;
                }

                var result = n1 + n2;
                fibs.Add(result);
                
                RFibs(result, n1);
            }

            #endregion
        }

        public void RunIterative(int priorA, int priorB)
        {
            for (int i = 0; i < MaxSequence; i++)
            {
                int current = priorA + priorB;
                priorB = priorA;
                priorA = current;

                fibs.Add(current);
            }
        }
    }
}
