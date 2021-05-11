using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.HashTable
{
    public class TwoSumIII
    {
        /** Initialize your data structure here. */
        Dictionary<int, int> dict; 

        public TwoSumIII()
        {
           dict= new Dictionary<int, int>();
        }

        /** Add the number to an internal data structure.. */
        public void Add(int number)
        {
            if (dict.ContainsKey(number))
            {
                dict[number] += 1;
            }
            else
            {
                dict.Add(number, 1);
            }
        }

        /** Find if there exists any pair of numbers which sum is equal to the value. */
        public bool Find(int value)
        {
            // nums = [2,7,11,15], target = 9
            foreach (var item in dict)
            {
               int  complement = value - item.Key;
                if(complement != item.Key)
                {
                    if (dict.ContainsKey(complement))
                        return true;
                }
                else
                {
                    if (item.Value > 1)
                        return true;
                }


            }
            return false;
        }
    }
}
/**
 * Your TwoSum object will be instantiated and called as such:
 * TwoSum obj = new TwoSum();
 * obj.Add(number);
 * bool param_2 = obj.Find(value);
 */