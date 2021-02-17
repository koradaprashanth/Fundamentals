using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.HashTable
{
    public class TwoSum
    {
        public int[] TwoSumMethod(int[] nums, int target)
        {
            // nums = [2,7,11,15], target = 9

            Dictionary<int, int> dc = new Dictionary<int, int>();
            //HashSet<int> hash = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dc.ContainsKey(nums[i]))
                {
                    return new int[] { dc[nums[i]], i };
                }
                else
                {
                    dc.Add(target - nums[i],i);
                }                
            }

            return new int[] { };
        }
    }
}
