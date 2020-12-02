using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.LinkedLists
{
    public class ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            //TODO : Need to Analyse this algo
            //Input 1->2->3->4->5->NULL
            //Output: 5->4->3->2->1->NULL
            ListNode prev = null;
            ListNode curr = head;
            while (curr != null)
            {
                ListNode newTemp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = newTemp;                
            }

            return prev;
        }
    }
}
