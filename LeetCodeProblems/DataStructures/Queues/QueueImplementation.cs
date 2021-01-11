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



        //private List<int> data;
        //// a pointer to indicate the start position
        //private int p_start;
        //public MyQueue()
        //{
        //    data = new List<int>();
        //    p_start = 0;
        //}
        ///** Insert an element into the queue. Return true if the operation is successful. */
        //public boolean enQueue(int x)
        //{
        //    data.add(x);
        //    return true;
        //}
        ///** Delete an element from the queue. Return true if the operation is successful. */
        //public boolean deQueue()
        //{
        //    if (isEmpty() == true)
        //    {
        //        return false;
        //    }
        //    p_start++;
        //    return true;
        //}
        ///** Get the front item from the queue. */
        //public int Front()
        //{
        //    return data.get(p_start);
        //}
        ///** Checks whether the queue is empty or not. */
        //public boolean isEmpty()
        //{
        //    return p_start >= data.size();
        //}

        ////////Invoking////////

        //  MyQueue q = new MyQueue();
        //q.enQueue(5);
        //q.enQueue(3);
        //if (q.isEmpty() == false) {
        //    System.out.println(q.Front());
        //}
        //q.deQueue();
        //if (q.isEmpty() == false) {
        //    System.out.println(q.Front());
        //}
        //q.deQueue();
        //if (q.isEmpty() == false) {
        //    System.out.println(q.Front());
        //}
    }
}
