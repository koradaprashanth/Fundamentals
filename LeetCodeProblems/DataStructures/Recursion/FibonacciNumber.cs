using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Recursion
{
    public class FibonacciNumber
    {
        public int Fib(int n)
        {
            //recursive  time : O(2^N) space: O(N)
            if (n < 2)
            {
                return n;
            }
            return Fib(n - 1) + Fib(n - 2);
            //int sum=0;

            //sum = sum + Fib(n - 1) + Fib(n - 2);

            //return sum;


            //Iterative - Time : O(N) Space: O(1)

            //if (N <= 1)
            //{
            //    return N;
            //}
            //if (N == 2)
            //{
            //    return 1;
            //}

            //int current = 0;
            //int prev1 = 1;
            //int prev2 = 1;

            //for (int i = 3; i <= N; i++)
            //{
            //    current = prev1 + prev2;
            //    prev2 = prev1;
            //    prev1 = current;
            //}
            //return current;



        // Top down using memoizing - Time : O(N) , Space : O(N) 
        // private Integer[] cache = new Integer[31];

        //public int fib(int N)
        //{
        //    if (N <= 1)
        //    {
        //        return N;
        //    }
        //    cache[0] = 0;
        //    cache[1] = 1;
        //    return memoize(N);
        //}

        //public int memoize(int N)
        //{
        //    if (cache[N] != null)
        //    {
        //        return cache[N];
        //    }
        //    cache[N] = memoize(N - 1) + memoize(N - 2);
        //    return memoize(N);
        //}
    }
    }
}
