using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Arrays
{
    public class RemoveElement
    {
        public void RemoveElementMethod(int[] nums, int val)
        {
            // 3, 2, 2, 3 
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }

            Console.WriteLine(k);

            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine(nums[j]);
            }
            Console.ReadLine();
        }
    }
}
