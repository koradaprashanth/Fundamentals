using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.HashTable
{
    public class SingleNumber
    {
        public int SingleNumberMethod(int[] nums)
        {
            //4,1,2,1,2
            //List<int> hs = new List<int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (hs.Contains(nums[i]))
            //        hs.Remove(nums[i]);
            //    else
            //        hs.Add(nums[i]);

            //}

            //return hs[0];


            int a = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                a ^= nums[i];
            }

            return a;
        }
    }
}
