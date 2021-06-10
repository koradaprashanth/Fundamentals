using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Stacks
{
    public class EvaluateReversePolishNotation
    {
        //["2","1","+","3","*"]
        public int EvalRPN(string[] tokens)
        {
            if (tokens == null || tokens.Length == 0)
                return 0;

            Stack<int> nums = new Stack<int>();

            foreach (var token in tokens)
                if (token == "+" || token == "-" || token == "*" || token == "/")
                {
                    int n1 = nums.Pop(),
                        n2 = nums.Pop();

                    if (token == "+")
                        nums.Push(n2 + n1);
                    else if (token == "-")
                        nums.Push(n2 - n1);
                    else if (token == "*")
                        nums.Push(n2 * n1);
                    else
                        nums.Push(n2 / n1);
                }
                else
                    nums.Push(Convert.ToInt32(token));

            return nums.Peek();
        }

    }
}
