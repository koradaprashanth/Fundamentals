using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Queues
{
    public class CircularQueueDesign
    {

        private ListNode head, tail;
        private int count;
        private int capacity;

        /** Initialize your data structure here. Set the size of the queue to be k. */
        public CircularQueueDesign(int k)
        {
            this.capacity = k;
        }

        /** Insert an element into the circular queue. Return true if the operation is successful. */
        public bool enQueue(int value)
        {
            if (this.count == this.capacity)
                return false;

            ListNode newNode = new ListNode(value);
            if (this.count == 0)
            {
                head = tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
            this.count += 1;
            return true;
        }

        /** Delete an element from the circular queue. Return true if the operation is successful. */
        public bool deQueue()
        {
            if (this.count == 0)
                return false;
            this.head = this.head.next;
            this.count -= 1;
            return true;
        }

        /** Get the front item from the queue. */
        public int Front()
        {
            if (this.count == 0)
                return -1;
            else
                return this.head.val;
        }

        /** Get the last item from the queue. */
        public int Rear()
        {
            if (this.count == 0)
                return -1;
            else
                return this.tail.val;
        }

        /** Checks whether the circular queue is empty or not. */
        public bool isEmpty()
        {
            return (this.count == 0);
        }

        /** Checks whether the circular queue is full or not. */
        public bool isFull()
        {
            return (this.count == this.capacity);
        }
        
        // Time complexity: O(1)\mathcal{O }
        //    (1)O(1) for each method in our circular queue.
        //Space Complexity: The upper bound of the memory consumption for our circular queue would be O(N)\mathcal{O
        //}
        //(N) O(N), same as the Array approach.However, it should be more memory efficient as we discussed in the intuition section.


        //Approach 1 : using array
        //private int[] queue;
        //private int headIndex;
        //private int count;
        //private int capacity;

        ///** Initialize your data structure here. Set the size of the queue to be k. */
        //public MyCircularQueue(int k)
        //{
        //    this.capacity = k;
        //    this.queue = new int[k];
        //    this.headIndex = 0;
        //    this.count = 0;
        //}

        ///** Insert an element into the circular queue. Return true if the operation is successful. */
        //public boolean enQueue(int value)
        //{
        //    if (this.count == this.capacity)
        //        return false;
        //    this.queue[(this.headIndex + this.count) % this.capacity] = value;
        //    this.count += 1;
        //    return true;
        //}

        ///** Delete an element from the circular queue. Return true if the operation is successful. */
        //public boolean deQueue()
        //{
        //    if (this.count == 0)
        //        return false;
        //    this.headIndex = (this.headIndex + 1) % this.capacity;
        //    this.count -= 1;
        //    return true;
        //}

        ///** Get the front item from the queue. */
        //public int Front()
        //{
        //    if (this.count == 0)
        //        return -1;
        //    return this.queue[this.headIndex];
        //}

        ///** Get the last item from the queue. */
        //public int Rear()
        //{
        //    if (this.count == 0)
        //        return -1;
        //    int tailIndex = (this.headIndex + this.count - 1) % this.capacity;
        //    return this.queue[tailIndex];
        //}

        ///** Checks whether the circular queue is empty or not. */
        //public boolean isEmpty()
        //{
        //    return (this.count == 0);
        //}

        ///** Checks whether the circular queue is full or not. */
        //public boolean isFull()
        //{
        //    return (this.count == this.capacity);
        //}

        //    Complexity

        //    Time complexity: O(1)\mathcal{O        //    }
        //    (1)O(1). All of the methods in our circular data structure is of constant time complexity.
        //    Space Complexity: O(N)\mathcal{ O}
        //    (N) O(N). The overall space complexity of the data structure is linear, where NNN is the pre-assigned capacity of the queue.However, it is worth mentioning that the memory consumption of the data structure remains as its pre-assigned capacity during its entire life cycle.


    }
}
