using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.BinarySearch
{
    //TODO
    public class SearchRotatedSortedArray
    {
        public int Search(int[] nums, int target)
        {
            HashSet<int> hs = new HashSet<int>(nums);
            var arr = new List<int>(hs).ToArray();
            foreach (var item in hs)
            {

            }
            
            //[4,5,6,7,0,1,2], target = 0
            if (nums == null || nums.Length == 0) return -1;

            int left = 0, right = nums.Length - 1;
            //find the smallest integer in the array, position. loops breaks at the left index reaches smallest value
            while(left < right)
            {
                int midpoint = left + (right - left) / 2;
                if (nums[midpoint] > nums[right])
                    left = midpoint + 1;
                else
                    right = midpoint;
            }

            int start = left;
            left = 0;
            right = nums.Length - 1;
            //find which side of the smallest interger, we need apply binary search to find the target element.
            if (target >= nums[start] && target <= nums[right])
                left = start;
            else
                right = start;


            //finally apply binary search the side that applies to the target element.
            while (left <= right)
            {
                int midpoint = left + (right - left) / 2;
                if (nums[midpoint] == target)
                    return midpoint;
                else if (nums[midpoint] < target)
                    left = midpoint + 1;
                else
                    right = midpoint-1;
            }

            return -1;
        }
    }
}
