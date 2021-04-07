using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.HashTable
{
    public class IntersectionOfTwoArrays11
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            //nums1 = [1,2,2,1], nums2 = [2,2]

            Dictionary<int, int> numsandCount = new Dictionary<int, int>();

            foreach (var item in nums1)
            {
                if (!numsandCount.ContainsKey(item)) numsandCount[item] = 0;

                numsandCount[item]++;
            }

            var result = new List<int>();

            foreach (var item in nums2)
            {
                if(numsandCount.ContainsKey(item) && numsandCount[item] > 0)
                {
                    result.Add(item);

                    numsandCount[item]--;
                }
            }

            return result.ToArray();
        }
    }
}
