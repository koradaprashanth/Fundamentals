using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Arrays
{
    public class RepeatedDeletionAlgorithm
    {
        public int RepeatedDeletionAlgorithmMethod(int[] nums)
        {
            //0, 0, 1, 1, 1, 2, 2, 3, 3, 4

            #region Using additional array 

            //if(nums==null || nums.Length == 0)
            //{
            //    return nums;
            //}

            //int possibleUniqueNums = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (i == 0 || nums[i] != nums[i - 1])
            //        possibleUniqueNums++;
            //}

            //int[] resultArray = new int[possibleUniqueNums];
            //int positionInArray = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (i == 0 || nums[i] != nums[i - 1])
            //    {
            //        resultArray[positionInArray] = nums[i];
            //        positionInArray++;
            //    }
            //}


            //return resultArray;

            #endregion

            #region using InPlace array

            //0, 0, 1, 1, 1, 2, 2, 3, 3, 4
            int possibleUniqueNums = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[possibleUniqueNums])
                {
                    possibleUniqueNums++;
                    nums[possibleUniqueNums] = nums[i];
                   
                }
            }
            return possibleUniqueNums+1;


            #endregion


        }
    }
}
