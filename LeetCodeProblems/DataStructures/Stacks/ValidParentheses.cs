using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Stacks
{
    public class ValidParentheses
    {
        //( ( ( ) ( ( ) ) ) )

        //public Dictionary<char, char> dc;
        //public Stack<char> st = new Stack<char>();
        //public ValidParentheses()
        //{
        //    dc = new Dictionary<char, char>();
        //    dc.Add(')', '(');
        //    dc.Add('}', '{');
        //    dc.Add(']', '[');
        //}
        //public bool IsValid(string s)
        //{
        //    char[] chArray = s.ToCharArray();

        //    for (int i = 0; i < chArray.Length; i++)
        //    {
        //        if(dc.ContainsKey(chArray[i]))
        //        {
        //            char curr = st.Count == 0 ? '#' : st.Pop();

        //            if (curr != dc[chArray[i]])
        //                return false;
        //        }
        //        else
        //        {
        //            st.Push(chArray[i]);
        //        }
        //    }
        //    return st.Count == 0;
        //}

        public char[][] tokens = { new char[] { '(', ')' },
            new char[] { '{','}'}, new char[] { '[',']'} };
        public bool IsValid(string s)
        {
            Stack<char> st = new Stack<char>();
            foreach (var token in s.ToCharArray())
            {
                if (isOpenToken(token))
                {
                    st.Push(token);
                }
                else
                {
                    if (st.Count == 0 || !matches(st.Pop(), token))
                    {
                        return false;
                    }
                   
                }
            }

            return st.Count == 0;
        }

        private bool isOpenToken(char token)
        {
            for (int i = 0; i < tokens.Length; i++)
            {
                if (tokens[i][0] == token) return true;

            }
            return false;
        }

        private bool matches(char isopen,char isclose)
        {
            for (int i = 0; i < tokens.Length; i++)
            {
                if (tokens[i][0] == isopen)
                {
                    return tokens[i][1] == isclose;
                }
            }
            return false;
        }
    }

}
