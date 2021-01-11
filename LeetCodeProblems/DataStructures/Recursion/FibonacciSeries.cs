using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Recursion
{
    public class FibonacciSeries
    {
        Dictionary<int, int> cache = new Dictionary<int, int>();
        private int Fib(int N)
        {
            //Fibonacci Series
            if (cache.ContainsKey(N))
            {
                return cache[N];
            }

            int result;
            if (N < 2)
            {
                result = N;
            }
            else
            {
                result = Fib(N - 1) + Fib(N - 2);
            }

            cache.Add(N,result);

            return result;
        }
    }
}
