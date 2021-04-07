using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.HashTable
{
    public class ContainsNearbyDuplicate
    {
        public bool ContainsNearbyDuplicateMethod(int[] nums, int k)
        {
            if (k == 0 || nums == null || nums.Length <= 1) return false;
            HashSet<int> q = new HashSet<int>(k);
            for (int i = 0; i < nums.Length; i++)
            {
                if (q.Contains(nums[i])) return true;
                if (q.Count == k)
                {
                    q.Remove(nums[i - k]);
                }
                q.Add(nums[i]);
            }
            return false;
        }
    }
}
