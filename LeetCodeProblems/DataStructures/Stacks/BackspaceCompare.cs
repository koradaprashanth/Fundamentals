using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Stacks
{
    public class BackspaceCompare
    {

        public bool BackspaceCompareMethod(string s, string t)
        {
            if (s.Length == 0 && t.Length == 0) return true;

            string sFinal = "";
            Stack<char> sStack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '#' && sStack.Count > 0)
                {
                    sStack.Pop();
                }
                else if(s[i] !='#')
                {
                    sStack.Push(s[i]);
                }
                else
                {
                    continue;
                }
            }

            while (sStack.Count > 0)
            {
                sFinal = sFinal + sStack.Pop();
            }
            string tFinal = "";
            Stack<char> tStack = new Stack<char>();
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == '#' && tStack.Count > 0)
                {
                    tStack.Pop();
                }
                else if(t[i] !='#')
                {
                    tStack.Push(t[i]);
                }
                else
                {
                    continue;
                }
            }

            while (tStack.Count > 0)
            {
                tFinal = tFinal + tStack.Pop();
            }


            return sFinal == tFinal;
        }

    }
}
