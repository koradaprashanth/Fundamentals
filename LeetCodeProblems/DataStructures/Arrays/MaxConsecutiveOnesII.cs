using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Arrays
{
    public class MaxConsecutiveOnesII
    {
        public void FindMaxConsecutiveOnes(int[] nums)
        {
            //https://www.youtube.com/watch?v=OaMbeeSSv7Y
            //1,0,1,1,0
            //sliding window concept


            int maxConsecutiveCount = 0;
            int k = 1; // possible no of flips of 0 to 1
            int start = 0;
            int zerosCount = 0;
            for (int end = 0; end < nums.Length; end++)
            {
                if (nums[end] == 0)
                {
                    zerosCount++;
                }

                while(zerosCount > k)
                {
                    if (nums[start] == 0)
                    {
                        zerosCount--;
                    }
                    start++;
                }

                maxConsecutiveCount = Math.Max(maxConsecutiveCount, end - start + 1);

            }

            Console.WriteLine(maxConsecutiveCount);
            Console.ReadLine();
        }
    }
}
