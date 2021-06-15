using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.BinarySearch
{
    public class BinarySearch
    {
        //nums = [-1,0,3,5,9,12], target = 9
        public int Search(int[] nums, int target)
        {

            int left = 0, pivot, right = nums.Length - 1;
            while(left<= right)
            {
                pivot= left + (right-left)/ 2;
                if (nums[pivot] == target) return pivot;
                if (nums[pivot] < target) right = pivot + 1;
                else left = pivot - 1;
            }
            return -1;
        }
    }
}
