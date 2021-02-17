using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.DataStructures.HashTable
{
    public class IntersectionOfTwoArrays
    {
        public int[] IntersectionMethod(int[] nums1, int[] nums2)
        {
            HashSet<int> hs1 = new HashSet<int>(nums1);

            var hs2 = new HashSet<int>();

            for (int i = 0; i < nums2.Length; i++)
            {
                if (hs1.Contains(nums2[i]))
                {
                    hs2.Add(nums2[i]);
                }
            }

            return hs2.ToArray();
        }
    }
}
