using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.HashTable
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            //abcabcbb;

            if (s.Length == 0) return 0;
            int a_pointer = 0;
            int b_pointer = 0;
            int max = 0;

            HashSet<char> hs = new HashSet<char>();
            while (b_pointer < s.Length)
            {
                if (!hs.Contains(s[b_pointer]))
                {
                    hs.Add(s[b_pointer]);
                    b_pointer++;
                    max = Math.Max(max, hs.Count);
                }
                else
                {
                    
                    hs.Remove(s[a_pointer]);                    
                    a_pointer++;

                }


            }

            return max;


        }
    }
}
