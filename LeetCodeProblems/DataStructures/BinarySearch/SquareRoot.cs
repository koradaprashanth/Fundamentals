using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.BinarySearch
{
    public class SquareRoot
    {
        //8 REDO
        public int MySqrt(int x)
        {
            if (x == 0) return 0;

            long left = 0;
            long right = int.MaxValue / 2 + 1;

            while (left < right)
            {
                long mid = left + (right - left) / 2;
                long candidate = mid * mid;
                if (candidate == mid)
                {
                    return (int)candidate;
                }
                else if (candidate > x)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return (int)left - 1;
        }
    }
}
