using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.HashTable
{
    public class JewelsAndStones
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            //Input: jewels = "aA", stones = "aAAbbbb"
            //Output: 3

            //Dictionary<char, int> dc = new Dictionary<char, int>();
            //for (int i = 0; i < stones.Length; i++)
            //{
            //    if (!dc.ContainsKey(stones[i]))
            //    {
            //        dc.Add(stones[i], 1);
            //    }
            //    else
            //    {
            //        dc[stones[i]] += 1;
            //    }

            //}

            //int counter = 0;
            //for (int i = 0; i < jewels.Length; i++)
            //{
            //    if (dc.ContainsKey(jewels[i]))
            //    {
            //        counter += dc[jewels[i]];
            //    }
            //}

            //return counter;


            HashSet<char> hs = new HashSet<char>();
            foreach (var item in jewels.ToCharArray())
            {
                hs.Add(item);
            }

            int ans = 0;
            foreach (var item in stones.ToCharArray())
            {
                if (hs.Contains(item))
                    ans += 1;
            }

            return ans;



        }
    }
}
