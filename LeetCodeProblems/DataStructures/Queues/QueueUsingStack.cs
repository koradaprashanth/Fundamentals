using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Queues
{
    public class QueueUsingStack
    {
        Stack<int> s1;

        /** Initialize your data structure here. */
        public QueueUsingStack()
        {
            s1 = new Stack<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            var newStack = new Stack<int>();
            while (s1.Count > 0)
            {
                newStack.Push(s1.Pop());
            }
            newStack.Push(x);
            while (newStack.Count > 0)
            {
                s1.Push(newStack.Pop());
            }
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
           return s1.Pop();
        }

        /** Get the front element. */
        public int Peek()
        {
            return s1.Peek();
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return s1.Count == 0;
        }
    }
}
