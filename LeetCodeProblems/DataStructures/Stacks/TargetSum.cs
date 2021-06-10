using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Stacks
{
    //Redo other approaches
    public class TargetSum
    {
        int count = 0;
        public int FindTargetSumWays(int[] nums, int target)
        {
            Calculate(nums, 0, 0, target);
            return count;

        }

        public void Calculate(int[] nums,int i,int sum,int target)
        {
            if(i == nums.Length)
            {
                if (sum == target)
                {
                    count++;
                }
            }
            else
            {
                Calculate(nums, i + 1, sum + nums[i], target);
                Calculate(nums,i+1,sum-nums[i],target);
            }

        }
    }
}
