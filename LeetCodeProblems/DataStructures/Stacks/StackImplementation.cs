using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Stacks
{
    public class StackImplementation
    {
        private ListNode top;

        public bool isEmpty()
        {
            return top == null;
        }

        public int peek()
        {
            return top.val;   
        }

        public void push(int data)
        {
            ListNode node = new ListNode(data);

            node.next = top;

            top = node;
        }

        public int pop()
        {
            int val =top.val;
            top = top.next;
            return val;

        }
    }
}
