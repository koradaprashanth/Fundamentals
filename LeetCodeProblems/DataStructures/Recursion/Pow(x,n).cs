using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Recursion
{
    public class Pow_x_n_
    {
        public double MyPow(double x, int n)
        {

            // Brute Force 

            //    long N = n;
            //    if (N < 0)
            //    {
            //        x = 1 / x;
            //        N = -N;
            //    }
            //    double ans = 1;
            //    for (long i = 0; i < N; i++)
            //        ans = ans * x;
            //    return ans;

            //O(n) and O(1)

            //Fast Power Algorithm Recursive
            long N = n;
            if (N < 0)
            {
                x = 1 / x;
                N = -N;
            }

            return fastPow(x, N);

            //O(logn) and O(logn)


            //Fast Power Algorithm Iterative

            //long N = n;
            //if (N < 0)
            //{
            //    x = 1 / x;
            //    N = -N;
            //}
            //double ans = 1;
            //double current_product = x;
            //for (long i = N; i > 0; i /= 2)
            //{
            //    if ((i % 2) == 1)
            //    {
            //        ans = ans * current_product;
            //    }
            //    current_product = current_product * current_product;
            //}
            //return ans;

            //O(log n) and O(1)

        }

        private double fastPow(double x, long n)
        {
            if (n == 0)
            {
                return 1.0;
            }
            double half = fastPow(x, n / 2);
            if (n % 2 == 0)
            {
                return half * half;
            }
            else
            {
                return half * half * x;
            }
        }
    }
}
