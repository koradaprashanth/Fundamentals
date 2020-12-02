using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Queues
{
    public class QueueImplementation
    {

        private ListNode head; //remove from the head
        private ListNode tail; //add things here

        public bool isEmpty() 
        {
            return head == null;
        
        }
        public int peek() 
        {
            return head.val;
        }

        public void add(int data)
        {
            ListNode node = new ListNode(data);
            if (tail != null)
            {
                tail.next = node;
            }
            tail = node;

            if (head == null)
            {
                head = node;
            }
                        
        }

        public int remove()
        {
            int data = head.val;
            head = head.next;
            if (head == null)
            {
                tail = null;
            }
            return data;
        }

    }


    public class MyQueue
    {
        // store elements
        private List<int> data;
        // a pointer to indicate the start position
        private int p_start;
        public MyQueue()
        {
            data = new List<int>();
            p_start = 0;
        }

        public bool enQueue(int val)
        {
            data.Add(val);
            return true;
        }

        public bool deQueue()
        {
            if (isEmpty())
            {
                return false;
            }
            p_start++;
            return true;
        }

        public int Front()
        {
            return data[p_start];

        }

        public bool isEmpty()
        {
           return data.Count == 0;
        }
    }
}
