using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.BinarySearch
{
    public class TwoSum
    {   //REDO:
        public int[] TwoSumII(int[] numbers, int target)
        {

            int start = 0;
            int end = numbers.Length - 1;
            while (start < end)
            {
                if (numbers[start] + numbers[end] == target)
                    return new int[] { start + 1, end + 1 };
                else if (numbers[start] + numbers[end] > target)
                    end--;
                else
                    start++;
            }
            return new int[] { };
        }
    }
}