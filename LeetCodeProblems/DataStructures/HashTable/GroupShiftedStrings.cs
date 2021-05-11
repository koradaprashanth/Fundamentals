using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.HashTable
{
    public class GroupShiftedStrings
    {
        public IList<IList<string>> GroupStrings(string[] strings)
        {
            //Input: strings = ["abc", "bcd", "acef", "xyz", "az", "ba", "a", "z"]
            //Output:[["acef"],["a","z"],["abc","bcd","xyz"],["az","ba"]]

            var dict = new Dictionary<string, List<string>>();

            foreach (var str in strings)
            {
                var sb = new StringBuilder();

                for (var i = 1; i < str.Length; i++)
                {
                    sb.Append((str[i] - str[i - 1] + 26) % 26 + " ");
                }

                if (dict.ContainsKey(sb.ToString()))
                    dict[sb.ToString()].Add(str);
                else
                    dict[sb.ToString()] = new List<string> { str };
            }

            var result = new List<IList<string>>();
            foreach (var item in dict)
            {
                result.Add(item.Value);
            }
            return result;
        }


    }
    
}
