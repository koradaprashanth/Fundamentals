using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Arrays
{
    public class FindMissingNumbersInArray
    {
        public void  FindDisappearedNumbers(int[] nums)
        {
            ///4, 3, 2, 7, 8, 2, 3, 1 
            ///
            #region bool Solution 

            bool[] values = new bool[nums.Length+1];
            foreach (var t in nums)
                values[t] = true;

            var lstArray = new List<int>();
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] == false)
                    lstArray.Add(i);
            }


            #endregion

            #region normal Solution

            //HashSet<int> hashSet = new HashSet<int>();
            //List<int> lstArray = new List<int>();
            //for (int k = 0; k < nums.Length; k++)
            //{
            //    //    if (hashSet.Contains(nums[i]))
            //    //    {
            //    //        lstArray.Add(nums[i]);
            //    //    }
            //    hashSet.Add(nums[k]);
            //}

            //int i = 0;
            //while (i < nums.Length)
            //{
            //    if (!hashSet.Contains(i))
            //    {
            //        lstArray.Add(i);
            //    }
            //    i++;
            //}



            #endregion


            for (int j = 0; j < lstArray.Count; j++)
            {
                Console.WriteLine(lstArray[j]);
            }

            Console.ReadLine();
        }
    }
}
