using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Recursion
{
    public class ClimbStairs
    {
        //https://www.youtube.com/watch?v=Hr8HDhhSvZc
        public int ClimbStairsMethod(int n)
        {

            if (n == 1)
            {
                return 1;
            }
            int first = 1;
            int second = 2;
            for (int i = 3; i <= n; i++)
            {
                int third = first + second;
                first = second;
                second = third;
            }
            return second;



            //if (n == 1)
            //{
            //    return 1;
            //}
            //int[] dp = new int[n + 1];
            //dp[1] = 1;
            //dp[2] = 2;
            //for (int i = 3; i <= n; i++)
            //{
            //    dp[i] = dp[i - 1] + dp[i - 2];
            //}
            //return dp[n];

            //O(N) , O(N)
        }


    }
}
