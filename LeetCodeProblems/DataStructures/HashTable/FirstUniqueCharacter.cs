using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.HashTable
{
    public class FirstUniqueCharacter
    {
        public int FirstUniqChar(string s)
        {
            //leetcode  or loveleetcode
            Dictionary<char, int> ds = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (ds.ContainsKey(s[i]))
                    ds[s[i]] += 1;
                else
                    ds.Add(s[i], 1);
            }


            for (int i = 0; i < s.Length; i++)
            {
                if(ds.ContainsKey(s[i]) && ds[s[i]] == 1)
                {
                    return i;
                }
            }
            return -1;
            

        }
    }
}
