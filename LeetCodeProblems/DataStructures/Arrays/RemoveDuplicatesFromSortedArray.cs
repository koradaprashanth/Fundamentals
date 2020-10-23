using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Arrays
{
    public class RemoveDuplicatesFromSortedArray
    {
        public void RemoveDuplicates(int[] nums)
        {
            int pointer1 = 0;
            for (int pointer2   = 1; pointer2 < nums.Length; pointer2++)
            {
                if(nums[pointer1]!= nums[pointer2])
                {
                    pointer1++;
                    nums[pointer1]= nums[pointer2];
                }

            }
            Console.WriteLine(pointer1+1);
            Console.ReadLine();

        }
    }
}
