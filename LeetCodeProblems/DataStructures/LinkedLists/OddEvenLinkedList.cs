using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.LinkedLists
{
    public class OddEvenLinkedList
    {
        public ListNode OddEvenList(ListNode head)
        {
            //Input: 2->1->3->5->6->4->7->NULL
            //Output: 2->3->6->7->1->5->4->NULL
            if (head == null) return null;
            ListNode odd = head,even = head.next,evenHead = even;
            
            while(even!=null && even.next != null)
            {
                odd.next = even.next;
                odd = odd.next;
                even.next = odd.next;
                even = even.next;
            }

            odd.next = evenHead;
            return head;

        }
    }
}
