using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.HashTable
{
    public class GroupAnagrams
    {
        public IList<IList<string>> GroupAnagramsMethod(string[] strs)
        {
            // ["eat","tea","tan","ate","nat","bat"]
            // [["bat"],["nat","tan"],["ate","eat","tea"]]

            IList<IList<String>> result = new List<IList<string>>();
            Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();
            for (int i = 0; i < strs.Length; i++)
            {
                string arr = "";char[] tempStr = strs[i].ToCharArray();
                Array.Sort(tempStr);
                for (int j = 0; j < tempStr.Length; j++)
                {
                    arr += tempStr[j];
                }



                if (!data.ContainsKey(arr))
                {
                    data[arr] = new List<string>() { strs[i] };
                }
                else
                {
                    data[arr].Add(strs[i]);
                }
            }


            foreach (var item in data.Keys)
            {
                result.Add(data[item]);
            }

            return result;

        }
    }
}
