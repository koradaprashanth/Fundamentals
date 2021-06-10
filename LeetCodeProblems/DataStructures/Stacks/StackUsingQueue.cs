using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Stacks
{
    public class StackUsingQueue
    {
        Queue<int> queue; //1,2 3
        /** Initialize your data structure here. */
        public StackUsingQueue()
        {
            queue = new Queue<int>();
        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            var newQueue = new Queue<int>();
            newQueue.Enqueue(x);
            while (queue.Count > 0)
            {
                newQueue.Enqueue(queue.Dequeue());
            }

            queue = newQueue;
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
           return queue.Dequeue();
        }

        /** Get the top element. */
        public int Top()
        {
            return queue.Peek();
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            return queue.Count == 0;
        }
    }
}
