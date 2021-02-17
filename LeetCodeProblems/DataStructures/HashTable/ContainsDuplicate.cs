using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.HashTable
{
    public class ContainsDuplicate
    {

        public bool ContainsDuplicateMethod(int[] nums)
        {
            if (nums.Length == 0) return false;

            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {

                if (hs.Contains(nums[i]))
                    return true;


                hs.Add(nums[i]);
            }

            return false;
        }
    }
}
