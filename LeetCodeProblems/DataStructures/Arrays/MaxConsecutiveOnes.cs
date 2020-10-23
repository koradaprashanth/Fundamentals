using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Arrays
{
    public class MaxConsecutiveOnes
    {
        public void MaxConsecutiveOnesMethod(int[] nums)
        {
            //110111 or 111011
            var max = 0;
            var sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
            
                if (nums[i] == 1)
                {
                    sum++; 
                }
                else
                {
                    sum = 0;
                }

                if (sum > max)
                {
                    max = sum;
                }


            }

            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
