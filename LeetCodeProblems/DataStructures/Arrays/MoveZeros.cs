using System;

namespace LeetCodeProblems.DataStructures.Arrays
{
    public class MoveZeros
    {
        public void MoveZeroes(int[] nums)
        {
            //0,1,0,3,12
            //1,0,1
            int pointer = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    int temp = nums[i];
                    nums[i] = nums[pointer];
                    nums[pointer] = temp;

                }

                if (nums[pointer] != 0)
                {
                    pointer++;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadLine();

        }
    }
}
