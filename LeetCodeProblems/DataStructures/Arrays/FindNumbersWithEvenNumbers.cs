using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Arrays
{
    public class FindNumbersWithEvenNumbers
    {
        public void FindNumbersMethod(int[] nums)
        {
            //[12,345,2,6,7896]
            int total = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (IsNumberLengthEven(nums[i]))
                {
                    total++;
                }
            }

            Console.WriteLine(total);
            Console.ReadLine();             
            
        }

        public bool IsNumberLengthEven(int val)
        {
            int length = 0;
            while (val > 0)
            {
                val = val / 10;
                length++;
            }
            return length % 2 == 0;
        }
    }
}
