using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Recursion
{
    public class SwapPairs
    {
        //https://www.youtube.com/watch?v=jiLloHVmLDc&t=300s
        public ListNode SwapPairsFuntion(ListNode head)
        {
            ListNode p, new_start;
            p = head;
            new_start = p.next;
            while (true)
            {
                ListNode q = p.next;
                ListNode temp = q.next;
                q.next = p;
                if(temp==null || temp.next == null)
                {
                    p.next = null;
                    break;
                }
                p.next = temp.next;
                p = temp;
            }

            return new_start;



            //// Dummy node acts as the prevNode for the head node
            //// of the list and hence stores pointer to the head node.
            //ListNode dummy = new ListNode(-1);
            //dummy.next = head;

            //ListNode prevNode = dummy;

            //while ((head != null) && (head.next != null))
            //{

            //    // Nodes to be swapped
            //    ListNode firstNode = head;
            //    ListNode secondNode = head.next;

            //    // Swapping
            //    prevNode.next = secondNode;
            //    firstNode.next = secondNode.next;
            //    secondNode.next = firstNode;

            //    // Reinitializing the head and prevNode for next swap
            //    prevNode = firstNode;
            //    head = firstNode.next; // jump
            //}

            //// Return the new head node.
            //return dummy.next;




            // If the list has no node or has only one node left.
            //if ((head == null) || (head.next == null))
            //{
            //    return head;
            //}

            //// Nodes to be swapped
            //ListNode firstNode = head;
            //ListNode secondNode = head.next;

            //// Swapping
            //firstNode.next = swapPairs(secondNode.next);
            //secondNode.next = firstNode;

            //// Now the head is the second node
            //return secondNode;
        }
    }
}
