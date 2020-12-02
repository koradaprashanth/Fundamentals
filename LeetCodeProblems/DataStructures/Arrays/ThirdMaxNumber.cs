using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Arrays
{
    public class ThirdMaxNumber
    {
        public int ThirdMaxMethod(int[] nums)
        {
            //2, 2, 3, 1
            //2,4,6,1,5,5

            Int64 max1 = Int64.MinValue;
            Int64 max2 = Int64.MinValue;
            Int64 max3 = Int64.MinValue;

            /*[1,2,2,5,3,5]
            1:
            1 0 0
            2:
            2 1 0
            2:

            */

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = nums[i];
                }
                else if (nums[i] > max2 && nums[i] != max1)
                {
                    max3 = max2;
                    max2 = nums[i];
                }
                else if (nums[i] > max3 && nums[i] != max2 && nums[i] != max1)
                {
                    max3 = nums[i];
                }
            }

            if (max3 != Int64.MinValue)
                return (int)max3;

            if (max1 != Int64.MinValue)
                return (int)max1;

            if (max2 != Int64.MinValue)
                return (int)max2;



            return Int32.MinValue;



        }
    }
}
