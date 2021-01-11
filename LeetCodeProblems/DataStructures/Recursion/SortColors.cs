using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Recursion
{
    public class SortColors
    {
        //Input: nums = [2,0,2,1,1,0]
        //Output: [0,0,1,1,2,2]

        public void SortColorsFun(int[] nums)
        {
            if (nums.Length == 0 || nums.Length == 1) return;

            int start = 0;
            int end = nums.Length - 1;
            int index = 0;

            while(index<=end && start < end)
            {
                if(nums[index] == 0)
                {
                    nums[index] = nums[start];
                    nums[start] = 0;
                    start++;
                    index++;
                }else if(nums[index] == 2)
                {
                    nums[index] = nums[end];
                    nums[end] = 2;
                    end--;
                }
                else
                {
                    index++;
                }
            }
        }
    }
}
