using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Stacks
{
    public class DecodeString
    {
        //3[a2[c]]//3[a]2[bc]
        public string DecodeStringMethod(string s)
        {
            Stack<int> counts = new Stack<int>();
            Stack<string> result = new Stack<string>();
            string res = "";
            int idx = 0;
            while(idx < s.Length)
            {
                if(s[idx] == '[')
                {
                    result.Push(res);
                    res = "";
                    idx++;

                }else if(s[idx] == ']')
                {
                    StringBuilder temp = new StringBuilder(result.Pop());
                    int rep = counts.Pop();
                    for (int i = 0; i < rep; i++)
                    {
                        temp.Append(res);
                    }
                    res = temp.ToString();
                    idx++;

                }else if (char.IsDigit(s[idx]))
                {
                    StringBuilder val = new StringBuilder();
                    //int count = 0;
                    while (char.IsDigit(s[idx]))
                    {
                        //count = 10 * count + (s[idx] - '0');
                        val.Append(s[idx]);
                        idx++;
                    }
                    counts.Push(Convert.ToInt32(val.ToString()));
                }
                else
                {
                    res += s[idx];
                    idx++;
                }
            }

            return res;
        }
    }
}
