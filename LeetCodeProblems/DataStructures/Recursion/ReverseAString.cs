using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Recursion
{
    public class ReverseAString
    {
        public void printReverse(char[] str)
        {
            helper(0, str);
        }

        public void helper(int index,char[] str)
        {
            if(str ==null || index >= str.Length)
            {
                return;
            }
            helper(index + 1, str);
            Console.WriteLine(str[index]);
        }


        public void helper(char[] s, int left, int right)
        {
            if (left >= right) return;
            char tmp = s[left];
            s[left++] = s[right];
            s[right--] = tmp;
            helper(s, left, right);
        }

        public void reverseString(char[] s)
        {
            //recursive
            //helper(s, 0, s.Length - 1);

            //TimeComplexity: O(N) to perform N/2 swaps.
            //SpaceComplexity: O(N) to keep recursion stack.

            //iterative - two pointers 
            int left = 0, right = s.Length - 1;
            while (left < right)
            {
                char tmp = s[left];
                s[left++] = s[right];
                s[right--] = tmp;
            }

            //TimeComplexity : O(N) to swap n/2 elements.
            //Space Complexity : O(1), its a constant space.

        }




    }
}
