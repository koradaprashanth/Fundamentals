using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.LinkedLists
{
    public class DesignLinkedList
    {
        int size;
        Node head;
        public DesignLinkedList()
        {
            size = 0;
            head = new Node(0);
        }
       
        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {

            
            if (index < 0 || index >= size) return -1;

            Node curr = head;

            for (int i = 0; i < index + 1; ++i)
            {
                curr = curr.next;
            }
            return curr.data;

        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, 
         * the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            // If index is greater than the length, 
            // the node will not be inserted.
            if (index > size) return;

            // [so weird] If index is negative, 
            // the node will be inserted at the head of the list.
            if (index < 0) index = 0;

            ++size;

            // find predecessor of the node to be added
            Node curr = head;
            for (int i = 0; i < index; ++i)
            {
                curr = curr.next;
            }

            // node to be added
            Node toAdd = new Node(val);

            // insertion itself
            toAdd.next = curr.next;
            curr.next = toAdd;

        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            // if the index is invalid, do nothing
            if (index < 0 || index >= size) return;

            size--;

            Node curr = head;
            for (int i = 0; i < index; ++i) curr = curr.next;

            curr.next = curr.next.next;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            AddAtIndex(0, val);
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            AddAtIndex(size,val);
        }

    }

    public class Node
    {
        // 1 2 3 4
        public Node next;
        public int data;
        public Node(int val)
        {
            this.data = val;
        }

       
    }

    public class LinkedList
    {
        Node head;

        public void append(int data)
        {
            if(head == null)
            {
                head = new Node(data);
                return;
            }

            Node curr = head;
            while (curr.next != null)
            {
                curr = curr.next;
            }
            curr.next = new Node(data);

        }


        public void prepend(int data)
        {
            Node newHead= new Node(data);
            newHead.next = head;
            head = newHead;
        }

        public void deleteWithValue(int data)
        {
            //1 2 3 4
            if (head == null) return;
            
            if (head.data == data)
            {
               head= head.next;
                return;
            }

            Node curr=head;
            while(curr.next != null)
            {
                if (curr.next.data == data)
                {
                    curr.next = curr.next.next;
                    return;
                }
                curr = curr.next;
            }

        }
    }
}
