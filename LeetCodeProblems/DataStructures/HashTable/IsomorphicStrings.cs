using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.HashTable
{
    public class IsomorphicStrings
    {
        public bool IsIsomorphic(string s, string t)
        {
            //"egg", "add" - true 
            //"foo", "bar" - false

            if (s.Length != t.Length)
                return false;
            
            Dictionary<char,char> ds = new Dictionary<char, char>();
            HashSet<char> hs = new HashSet<char>();
            bool result = true;
            for (int i = 0; i < s.Length; i++)
            {
                var s1 = s[i];
                var t1 = t[i];

                if (ds.ContainsKey(s1))
                {
                    if (ds[s1] != t1)
                    {
                        return false;
                    }

                }
                else
                {
                    if (hs.Contains(t1))
                    {
                        return false;

                    }
                    else
                    {
                        hs.Add(t1);
                        ds.Add(s1, t1);
                    }
                }



            }

            return result;








        }
    }
}
